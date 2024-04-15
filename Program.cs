using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe_w07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(
                new HumanPlayer(Mark.X),
                new ComputerPlayer(Mark.O)
                );
            game.Start();

            Console.ReadKey();
        }
    }

    
}
