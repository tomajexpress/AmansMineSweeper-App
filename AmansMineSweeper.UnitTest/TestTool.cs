using AmansMineSweeper.Constants;
using AmansMineSweeper.Model;
using AmansMineSweeper.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmansMineSweeper.UnitTest
{
    public static class TestTool
    {
        public static void AssertOutputs(GridPanel actualGrid, int[,] expectedGrid)
        {
            for (var row = GridPanelConstantValues.MinimumRow; row <= actualGrid.MaxRows; row++)
            {
                for (var column = GridPanelConstantValues.MinimumColumn; column <= actualGrid.MaxColumns; column++)
                {
                    Assert.AreEqual(expectedGrid[row, column], actualGrid[new Location() { Row = row, Column = column }]);
                }
            }
        }


        public static void ArrangeInputs(GridPanel actualGridPanel, int[,] array)
        {
            for (var row = 0; row <= actualGridPanel.MaxRows; row++)
            {
                for (var column = 0; column <= actualGridPanel.MaxColumns; column++)
                {
                    var location = new Location() { Row = row, Column = column};

                    actualGridPanel[location] = array[row, column];
                }
            }
        }

        public static GridPanel GetGridPanel(string filePath)
        {
            IGridPanelLoader gridLoder = new GridPanelTextFileLoader(filePath, new GridPanelMapper());

            return gridLoder.LoadGridPanel();
        }
    }
}
