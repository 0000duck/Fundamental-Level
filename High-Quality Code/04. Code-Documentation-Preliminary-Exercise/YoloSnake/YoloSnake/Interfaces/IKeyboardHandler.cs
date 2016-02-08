namespace YoloSnake.Interfaces
{
    using System;

    public interface IKeyboardHandler
    {
        /// <summary>
        /// Property for the current pressed key.
        /// </summary>
        ConsoleKey PressedKey { get; }

        /// <summary>
        /// Check if the key pressed is available.
        /// </summary>
        bool IsKeyAvailable { get; }
    }
}