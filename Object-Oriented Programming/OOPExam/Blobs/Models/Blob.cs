using System;
using Blobs.Enums;
using Blobs.Interfaces;

namespace Blobs.Models
{
    public class Blob : IBlob
    {
        private string name;
        private int health;
        private int attackDamage;
        private AttackType attackType;
        private BehaviorType behaviorType;
        public int triggerCounter;
        public int initialDamage;

        public Blob(string name, int health, int attackDamage, BehaviorType behaviorType, AttackType attackType)
        {
            this.Name = name;
            this.AttackDamage = attackDamage;
            this.InitHealth(health);
            this.BehaviorType = behaviorType;
            this.AttackType = attackType;
            this.triggerCounter = 0;
            this.initialDamage = attackDamage;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("name", "Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int AttackDamage
        {
            get
            {
                return this.attackDamage;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.attackDamage), "Attack damage cannot be negative.");
                }

                this.attackDamage = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public BehaviorType BehaviorType { get; set; }

        public AttackType AttackType { get; set; }

        private void InitHealth(int initialHealth)
        {
            if (initialHealth <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialHealth), "A blob's initial health should be positive.");
            }

            this.health = initialHealth;
        }

        public void TriggerBehavior()
        {
            if (this.BehaviorType == BehaviorType.Aggresive)
            {
                this.AttackDamage *= 2;
            }
            else
            {
                this.Health += 50;
            }
        }

        public void AttackBlob(Blob blob)
        {
            int initialHealth = this.Health;
            int initialEnemyHealth = blob.Health;

            if (blob.Health <= initialEnemyHealth / 2)
            {
                if (triggerCounter != 0)
                {
                    throw new Exception("A behavior can only be triggered once");
                }
                TriggerBehavior();
                triggerCounter++;
            }
            if (this.AttackType == AttackType.Blobplode)
            {
                this.Health %= 2;
                blob.Health -= 2 * this.AttackDamage;
            }
            else
            {
                blob.Health -= this.AttackDamage;
            }
        }
    }
}