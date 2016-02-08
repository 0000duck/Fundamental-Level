namespace YoloSnake.Interfaces
{
    using Enums;

    public interface IMovable
    {
        /// <summary>
        /// Property for the object's moving direction.
        /// </summary>
        Direction Direction { get; }

        /// <summary>
        /// Method for object move.
        /// </summary>
        void Move();

        /// <summary>
        /// Method for changing object's moving direction.
        /// </summary>
        /// <param name="newDirection"></param>
        void ChangeDirection(Direction newDirection);
    }
}