using AmansMineSweeper.Model;

namespace AmansMineSweeper.Service
{
    public interface IAdjacentCalculator
    {
        void CalculateBelowAdjacent(Location mineLocation);
        void CalculateBelowLeftAdjacent(Location mineLocation);
        void CalculateBelowRightAdjacent(Location mineLocation);
        void CalculateLeftAdjacent(Location mineLocation);
        void CalculateRightAdjacent(Location mineLocation);
        void CalculateUpperAdjacent(Location mineLocation);
        void CalculateUpperLeftAdjacent(Location mineLocation);
        void CalculateUpperRightAdjacent(Location mineLocation);
    }
}
