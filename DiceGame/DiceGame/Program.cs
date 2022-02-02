using System;
using System.Collections.Generic;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * BDD: Behavior Driven Development
             * 1. Oyuncu; ad ve soyadını girerek oyuna başlar.
             * 2. Her oyuncunun iki adet zarı vardır.
             * 3. Her zar 1-6 arasında bir sayıya sahiptio
             * 
             * 
             * 4. Oyun, 2 oyuncu ile oynanır.
             * 
             * 5. Oyuncular, sırayla zar atar
             * 6. Atilan zarlar karşılaştırılır
             * 7. Büyük atan kazanır
             * 
             * 
             */

            Game game = new Game();
            Player one = generatePlayer("Türkay");

            Player two = generatePlayer("Ramazan");

            game.PlayerOne = one;
            game.PlayerTwo = two;

            game.PlayerOneThrowDice();
            Console.WriteLine($"Oyuncu {game.PlayerOne.Name} Skoru: {game.PlayerOne.Score} ");
            game.PlayerTwoThrowDice();

            Console.WriteLine($"Oyuncu {game.PlayerTwo.Name} Skoru: {game.PlayerTwo.Score} ");

            game.CompareScores();

            showTheResult(game);

            Console.ReadLine();




        }

        private static void showTheResult(Game game)
        {
            Player winner = game.Winner;
            if (winner != null)
            {
                Console.WriteLine($"kazanan oyuncu: {winner.Name}");

            }
            else
            {
                Console.WriteLine("Berabere!!!!");
            }
        }

        private static Player generatePlayer(string name)
        {
            Player player = new Player();
            player.Name = name;
            Dice diceOneForPlayerOne = new Dice();
            Dice diceTwoForPlayerOne = new Dice();

            player.DiceObjects = new List<Dice>();
            player.DiceObjects.Add(diceOneForPlayerOne);
            player.DiceObjects.Add(diceTwoForPlayerOne);
            return player;
        }
    }
}
