using AmansMineSweeper.Constants;
using AmansMineSweeper.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmansMineSweeper.UnitTest
{
    [TestClass]
    public class GridPanelMapperTest
    {
        [TestMethod]
        public void MapArrayOfStringToGridPanel_MapsGivenStrings_ReturnedGridModelIsCorrectlyMapped()
        {
            // arrange
            var lines = new[]
            {
                "*..",
                "..*"
            };

            // act

            IGridPanelMapper gridMapper = new GridPanelMapper();

            var actualGrid = gridMapper.MapArrayOfStringToGridPanel(lines);


            // assert

            var expectedGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, 0, 0 }, 

                { 0, 0, GridPanelConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualGrid, expectedGrid);
        }
    }
}
