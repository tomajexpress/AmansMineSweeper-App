using AmansMineSweeper.Constants;
using AmansMineSweeper.Model;

namespace AmansMineSweeper.Service
{
    public class MineSweeperService : IMineSweeperService
    {
        private readonly IAdjacentCalculator _adjacentCalculator;

        public MineSweeperService(IAdjacentCalculator adjacentCalculator)
        {
            _adjacentCalculator = adjacentCalculator;
        }

        public void CalculateAdjacentValues(GridPanel gridPanel)
        {

            for (var row = GridPanelConstantValues.MinimumRow; row <= gridPanel.MaxRows; row++)
            {
                for (var column = GridPanelConstantValues.MinimumColumn; column <= gridPanel.MaxColumns; column++)
                {
                    var location = new Location { Row = row, Column = column };

                    if (gridPanel[location] == GridPanelConstantValues.Mine)
                    {
                        CalculateAdjacents(location);
                    }
                }
            }

        }


        private void CalculateAdjacents(Location location)
        {
            _adjacentCalculator.CalculateRightAdjacent(location);

            _adjacentCalculator.CalculateLeftAdjacent(location);

            _adjacentCalculator.CalculateUpperAdjacent(location);

            _adjacentCalculator.CalculateBelowAdjacent(location);

            //--------------------------------

            _adjacentCalculator.CalculateUpperLeftAdjacent(location);

            _adjacentCalculator.CalculateUpperRightAdjacent(location);

            _adjacentCalculator.CalculateBelowLeftAdjacent(location);

            _adjacentCalculator.CalculateBelowRightAdjacent(location);
        }
    }
}
