using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }

        public override void GameRound2(Hero attackerB, Hero defenderB, int attack)
        {
            string message = $"{attackerB.Name} attacked {defenderB.Name} for {attack} points";
            if (defenderB.IsAlive)
            {
                message = message + $" but {defenderB.Name} survived.";
            }
            else
            {
                message = message + $" and {defenderB.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Dragon dragon = new Dragon("Draco");
            Wizard wizard = new Wizard("Darios");
            
            Arena arena = new Arena(knight, rogue);
            arena.EventListener = new ConsoleGameEventListener();
            secondArena arena2 = new secondArena(wizard, dragon);
            arena2.EventListener = new ConsoleGameEventListener();

            Console.WriteLine("Battle begins.");
            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended.  Winner is: {winner.Name}");
            Console.ReadLine();
            Console.WriteLine("Second battle begins.");
            Hero winner2 = arena2.secondBattle();
            Console.WriteLine($"Battle ended.  Winner is: {winner2.Name}");
            Console.ReadLine();
        }
    }
}
