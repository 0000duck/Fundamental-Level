using Blobs.Enums;
using Blobs.Interfaces;
using Blobs.Models;

namespace Blobs.Core.Factories
{
    public class BlobFactory : IBlobFactory
    {
        public Blob CreateBlob(ICommand command)
        {
            string name = command.Parameters[0];
            int health = int.Parse(command.Parameters[1]);
            int attackDamage = int.Parse(command.Parameters[2]);
            BehaviorType behaviorType;
            if (command.Parameters[3] == "Inflated")
            {
                behaviorType = BehaviorType.Inflated;
            }
            else
            {
                behaviorType = BehaviorType.Aggresive;
            }
            AttackType attackType;
            if (command.Parameters[4] == "PutridFart")
            {
                attackType = AttackType.PutridFart;
            }
            else
            {
                attackType = AttackType.Blobplode;
            }

            var blob = new Blob(name, health, attackDamage, behaviorType, attackType);

            return blob;
        }
    }
}