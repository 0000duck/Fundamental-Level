﻿using System;

namespace EnvironmentSystem.Core
{
    using EnvironmentSystem.Interfaces;

    public delegate void PauseEventHandler(object sender, EventArgs args);
    class Controller : IController
    {
        public event EventHandler Pause;

        public void ProcessInput()
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                if (this.Pause != null)
                {
                    this.Pause(this, new EventArgs());
                }
            }
        }
    }
}