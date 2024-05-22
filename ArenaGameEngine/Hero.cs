namespace ArenaGameEngine
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            Strength = 60;
        }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public bool IsDead
        {
            get { return !IsAlive; }
        }

        public virtual int Attack()
        {
            int coef = Random.Shared.Next(80, 121);
            return (coef * Strength) / 100;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            Health = Health - incomingDamage;
        }
    }
}
