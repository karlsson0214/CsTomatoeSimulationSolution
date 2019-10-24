namespace TomatoeSimulation
{
    /// <summary>
    /// Interface used to revile enough information to the View about the TomatoeBox.
    /// </summary>
    public interface ITomatoeBoxView
    {
        /// <summary>
        /// Returns the number of tomatoes in the box.
        /// </summary>
        /// <returns></returns>
        int Size();

        /// <summary>
        /// Returns true if the tomatoe at the given position is ripe.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        bool IsRipeAt(int position);

    }
}