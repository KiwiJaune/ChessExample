using BobPlayers;
using ChessLibrary;

namespace ChessGame
{
    class Program
    {
        static void Main()
        {
            // This is OK, compile AND runtime :
            BobPlayer player1 = new BobPlayer();
            player1.PlayChessTurn();

            // This does not compile :
            IChessPlayer player2 = new BobPlayer(); // CS0012 The type 'IGoPlayer' is defined in an assembly that is not referenced. You must add a reference to assembly 'GoLibrary'.
            player2.PlayChessTurn();

            // This does not compile :
            BobPlayer player3 = new BobPlayer();
            PlayChess(player3); // CS0012 The type 'IGoPlayer' is defined in an assembly that is not referenced. You must add a reference to assembly 'GoLibrary'.

            System.Console.ReadLine();
        }

        static void PlayChess(IChessPlayer player)
        {
            player.PlayChessTurn();
        }
    }
}
