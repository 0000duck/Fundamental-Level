namespace YoloSnake.Interfaces
{
    public interface IDrawable
    {
        /// <summary>
        /// Method used to draw the object.
        /// </summary>
        /// <param name="drawer"></param>
        void Draw(IDrawer drawer);
    }
}