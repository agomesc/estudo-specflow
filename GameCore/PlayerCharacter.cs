namespace GameCore
{
    public class PlayerCharacter
    {
        public int Health { get; private set; } = 100;

        public bool IsDead { get; private set; }

        public void Hit(int demage)
        {
            this.Health -= demage;

            if (this.Health <= 0)
            {
                this.IsDead = true;
            }
        }
    }
}
