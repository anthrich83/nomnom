﻿using Nomnom.GameCode;
using System;

namespace Nomnom
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        public static Random RNG = new Random();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new GameState())
                game.Run();
        }
    }
#endif
}
