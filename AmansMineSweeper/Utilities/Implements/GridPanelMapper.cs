using System;
using System.Text;
using System.Collections.Generic;
using AmansMineSweeper.Constants;
using AmansMineSweeper.Model;

namespace AmansMineSweeper.Utilities
{
    public class GridPanelMapper : IGridPanelMapper
    {
        public GridPanel MapArrayOfStringToGridPanel(string[] lines)
        {
            var grid = new GridPanel(lines.GetLength(0), lines[0].Length);

            var row = 0;

            foreach (var line in lines)
            {
                var column = 0;

                foreach (var charachter in line)
                {
                    grid[new Location() { Row = row, Column = column }] = SymbolParser(charachter);

                    column = column + 1;
                }

                row = row + 1;
            }

            return grid;
        }

        public List<string> MapGridPanelToArrayOfString(GridPanel gridPanel)
        {
            var strings = new List<string>();

            for (var row = GridPanelConstantValues.MinimumRow; row <= gridPanel.MaxRows; row++)
            {
                var stringLine = new StringBuilder();

                for (var column = GridPanelConstantValues.MinimumColumn; column <= gridPanel.MaxColumns; column++)
                {
                    var symbol = SymbolParser(gridPanel[new Location() {Row = row, Column = column}]);

                    stringLine.Append(symbol);
                }

                strings.Add(stringLine.ToString());

                stringLine.Clear();
            }

            return strings;
        }

        private static int SymbolParser(char symbol)
        {
            switch (symbol)
            {
                case SymbolConstants.Mine:
                    return GridPanelConstantValues.Mine;

                case SymbolConstants.Dot:
                    return GridPanelConstantValues.Zero;
            }

            return Convert.ToInt32(symbol);
        }

        private static char SymbolParser(int number)
        {
            return GridPanelConstantValues.Mine == number ? SymbolConstants.Mine : Char.Parse(number.ToString());
        }
    }
}
