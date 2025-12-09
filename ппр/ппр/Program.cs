namespace ппр
{
 
                public class Priest : IHealthable
        {
            public void FullHeal()
            {
                Console.WriteLine("FullHeal");
            }

            public void Heal()
            {
                Console.WriteLine("Heal");
            }
        }

        public interface IHealthable
        {
            public void Heal();
            public void FullHeal();
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                var newPriest = new Priest();
                newPriest.FullHeal();
                newPriest.Heal();
            }
        }
    }