using System;

namespace GameCore
{
    public class PlayerCharacter
    {
        public int Health { get; private set; } = 100;

        public bool IsDead { get; private set; }

        public int DamageResistance { get; set; }

        public string Race { get; set; }

        public void Hit(int demage)
        {
            int raceEspecificDamageResitance = 0;
            int damage = 0;

            if (this.Race == "Elf")
            {
                raceEspecificDamageResitance = 20;
            }

            var totalDamageTaken = Math.Max(damage - raceEspecificDamageResitance - this.DamageResistance, 0);

            this.Health -= demage;

            if (this.Health <= 0)
            {
                this.IsDead = true;
            }
        }
    }
}
