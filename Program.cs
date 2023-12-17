using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunGame();
        }

        public static void RunGame()
        {
            GameCharacter Hero = new GameCharacter(100, 20, 40, "Hero");
            GameCharacter Boss = new GameCharacter(400, 20, 10, "Boss");


            Hero.Fight(Boss);
            Thread.Sleep(1500);
            Boss.Fight(Hero);

            while (Hero.Health > 0 && Boss.Health > 0)
            {
                Hero.Fight(Boss);
                if (Boss.Health == 0)
                {
                    Console.WriteLine($"{Hero.Name} won the fight!\n{Boss.Name} was defeated.");
                    break;
                }

                Boss.Fight(Hero);
                if (Hero.Health == 0)
                {
                    Console.WriteLine($"{Boss.Name} won the fight!\n{Hero.Name} was defeated.");
                    break;
                }
            }
        }
    }
}