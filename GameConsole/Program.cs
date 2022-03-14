using GameShared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class Program
    {
        static string gamesPath = @"D:\CapTraining\Games";
        static List<Type> games = new List<Type>();

        static void Main(string[] args)
        {
            var installeGames = Directory.GetFiles(gamesPath, "*.dll");
            foreach (var installeGame in installeGames)
            {
                Assembly asm = Assembly.LoadFile(installeGame);
                var types    = asm.GetTypes();

                foreach (var type in types)
                {
                    if(type.GetInterface(nameof(IGameService)) != null)
                    {
                        games.Add(type);
                    }
                }
            }

            DisplayGames();

            PlayGame(0);

        }

        static void DisplayGames()
        {
            if (games.Count > 0)
            {
                foreach (var game in games)
                {
                    GameAttribute gameAttribute = game.GetCustomAttribute<GameAttribute>();
                    if (gameAttribute != null)
                    {
                        Console.WriteLine($"{gameAttribute.Name} ------ {gameAttribute.Description}");
                    }
                    else
                        Console.WriteLine(game.Name);
                }
            }
            else
                Console.WriteLine("No games found");
        }

        static void PlayGame(int index)
        {
            Type game           = games[index];
            var instance        = Activator.CreateInstance(game);
            var gameStartMethod = game.GetMethod("Play");

            gameStartMethod.Invoke(instance,null);

        }
    }
}
