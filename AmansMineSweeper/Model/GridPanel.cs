using AmansMineSweeper.Constants;

namespace AmansMineSweeper.Model
{
    public class GridPanel
    {
        private readonly int[,] _gridCells;

        private readonly int _maxRows;

        private readonly int _maxColumns;

        public int MaxRows {
            get { return _maxRows-1; }
        }

        public int MaxColumns {
            get { return _maxColumns-1; }
        }


        public GridPanel(int maxRows, int maxColumns)
        {
            _maxRows = maxRows;

            _maxColumns = maxColumns;

            _gridCells = new int[maxRows, maxColumns];
        }

        public int this[Location cellLocation]
        {
            get { return _gridCells[cellLocation.Row, cellLocation.Column]; }

            set { _gridCells[cellLocation.Row, cellLocation.Column] = value; }
        }

        public void IncrementCellValue(Location location)
        {
            var currentValue = this[location];

            if (currentValue == GridPanelConstantValues.Mine) 
                return;

            this[location] = currentValue + 1;
        }

    }
}
