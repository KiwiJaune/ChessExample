using ChessLibrary;
using GoLibrary;
using System;

namespace BobPlayers
{
    public class BobPlayer : IChessPlayer, IGoPlayer
    {
        public void PlayChessTurn()
        {
            Console.WriteLine("I play chess...");
        }

        public void PlayGoTurn()
        {
            Console.WriteLine("I play go...");
        }
    }
}
