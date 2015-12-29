using System;
using System.Linq;
using System.Text;
using Blobs.Enums;
using Blobs.Interfaces;

namespace Blobs.Core
{
    public class Engine : ICommandExecutor
    {
        private readonly IBlobFactory blobFactory;
        private readonly IBlobData data;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;

        public Engine(IBlobFactory blobFactory, IBlobData data, IInputReader reader, IOutputWriter writer)
        {
            this.blobFactory = blobFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public virtual void Run()
        {
            while (true)
            {
                Command input = new Command(this.reader.ReadLine());

                this.ExecuteCommand(input);
            }
        }

        public void ExecuteCommand(ICommand command)
        {
            switch (command.Name)
            {
                case "create":
                    this.ExecuteCreateCommand(command);
                    break;
                case "attack":
                    this.ExecuteAttackCommand(command);
                    break;
                case "status":
                    this.ExecuteStatusCommand(command);
                    break;
                case "pass":
                    break;
                case "report-events":
                    this.ExecuteReportEventsCommand(command);
                    break;
                case "drop":
                    Environment.Exit(1);
                    break;
                default:
                    throw new ArgumentException("The command line is invalid.");
            }
        }

        private void ExecuteCreateCommand(ICommand command)
        {
            var blob = this.blobFactory.CreateBlob(command);
            this.data.AddBlob(blob);
        }

        private void ExecuteAttackCommand(ICommand command)
        {
            string blobName = command.Parameters[0];
            string blobEnemyName = command.Parameters[1];
            var blob = this.data.Blobs.FirstOrDefault(b => b.Name == blobName);
            var enemyBlob = this.data.Blobs.FirstOrDefault(b => b.Name == blobEnemyName);

            blob.AttackBlob(enemyBlob);
            ExecuteTurn();
        }

        private void ExecuteStatusCommand(ICommand command)
        {
            var blobs = this.data.Blobs;
            var output = new StringBuilder();
            foreach (var blob in blobs)
            {
                if (blob.Health == 0)
                {
                    output.AppendFormat($"Blob {blob.Name} KILLED").AppendLine();
                }
                else
                {
                    output.AppendFormat($"Blob {blob.Name}: {blob.Health} HP, {blob.AttackDamage} Damage").AppendLine();
                }
            }
            ExecuteTurn();

            this.writer.Print(output.ToString());
        }

        private void ExecuteTurn()
        {
            var blobs = this.data.Blobs;
            if (blobs != null)
            {
                foreach (var blob in blobs)
                {
                    if (blob.BehaviorType == BehaviorType.Aggresive)
                    {
                        while (blob.AttackDamage >= blob.initialDamage)
                        {
                            blob.AttackDamage -= 5;
                        }
                    }
                    else
                    {
                        blob.Health -= 10;
                    }
                }
            }

            // TODO: Implement it properly
        }

        private void ExecuteReportEventsCommand(ICommand command)
        {
            throw new NotImplementedException();
        }
    }
}