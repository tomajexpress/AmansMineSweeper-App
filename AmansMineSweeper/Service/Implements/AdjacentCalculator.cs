using AmansMineSweeper.Constants;
using AmansMineSweeper.Model;

namespace AmansMineSweeper.Service
{
    public class AdjacentCalculator : IAdjacentCalculator
    {
        private readonly GridPanel _gridPanel;

        public AdjacentCalculator(GridPanel gridPanel)
        {
            _gridPanel = gridPanel;
        }

        public void CalculateBelowAdjacent(Location location)
        {
            if (location.Row >= _gridPanel.MaxRows)
                return;

            var adjacentLocation = new Location
            {
                Row = GetRowDownIndex(location.Row),

                Column = location.Column
            };

            _gridPanel.IncrementCellValue(adjacentLocation);
        }


        public void CalculateBelowLeftAdjacent(Location location)
        {
            if (location.Row < _gridPanel.MaxRows && location.Column > GridPanelConstantValues.MinimumColumn)
            {
                _gridPanel.IncrementCellValue(new Location
                {
                    Row = GetRowDownIndex(location.Row),
                    Column = GetColumnLeftIndex(location.Column)
                });
            }
        }

        public void CalculateBelowRightAdjacent(Location location)
        {
            if (location.Row < _gridPanel.MaxRows && location.Column < _gridPanel.MaxColumns)
            {
                _gridPanel.IncrementCellValue(new Location
                {
                    Row = GetRowDownIndex(location.Row),
                    Column = GetColumnRightIndex(location.Column)
                });
            }
        }

        public void CalculateLeftAdjacent(Location location)
        {
            if (location.Column <= GridPanelConstantValues.MinimumColumn)
                return;

            _gridPanel.IncrementCellValue(new Location
            {
                Row = location.Row,
                Column = GetColumnLeftIndex(location.Column)
            });
        }

        public void CalculateRightAdjacent(Location location)
        {
            if (location.Column >= _gridPanel.MaxColumns)
                return;

            var adjacentLocation = new Location
            {
                Row = location.Row,
                Column = GetColumnRightIndex(location.Column)
            };

            _gridPanel.IncrementCellValue(adjacentLocation);
        }

        public void CalculateUpperAdjacent(Location location)
        {
            if (location.Row <= GridPanelConstantValues.MinimumRow)
                return;

            var adjacentLocation = new Location
            {
                Row = GetRowUpIndex(location.Row),
                Column = location.Column
            };

            _gridPanel.IncrementCellValue(adjacentLocation);
        }

        public void CalculateUpperLeftAdjacent(Location location)
        {
            if (location.Row > GridPanelConstantValues.MinimumRow && location.Column > GridPanelConstantValues.MinimumColumn)
            {
                _gridPanel.IncrementCellValue(new Location
                {
                    Row = GetRowUpIndex(location.Row),
                    Column = GetColumnLeftIndex(location.Column)
                });
            }
        }

        public void CalculateUpperRightAdjacent(Location location)
        {
            if (location.Row > GridPanelConstantValues.MinimumRow && location.Column < _gridPanel.MaxColumns)
            {
                _gridPanel.IncrementCellValue(new Location
                {
                    Row = GetRowUpIndex(location.Row),
                    Column = GetColumnRightIndex(location.Column)
                });
            }
        }


        private static int GetRowUpIndex(int row)
        {
            return --row;
        }

        private static int GetRowDownIndex(int row)
        {
            return ++row;
        }

        private static int GetColumnRightIndex(int column)
        {
            return ++column;
        }

        private static int GetColumnLeftIndex(int column)
        {
            return --column;
        }
    }
}
