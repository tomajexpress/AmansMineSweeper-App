using AmansMineSweeper.Constants;
using AmansMineSweeper.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmansMineSweeper.UnitTest
{
    [TestClass]
    public class MinesweeperTests
    {
        [TestCategory("LoadFromFile")]
        [TestMethod]
        public void MineSweeperServie_LoadsFromFileAndCalculatAdjacents_ReturnedGridPanelIsCorrect()
        {
            // arrange

            var gridPanel = TestTool.GetGridPanel("feld1.txt");

            // act

            IMineSweeperService meinSweeperService = new MineSweeperService(new AdjacentCalculator(gridPanel));

            meinSweeperService.CalculateAdjacentValues(gridPanel);

            // assert

            var expectedGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, GridPanelConstantValues.Mine, 1, 0, 0 }, 
                { 3, 3, 2, 0, 0 },
                { 1, GridPanelConstantValues.Mine, 1, 0, 0 },
            };


            TestTool.AssertOutputs(gridPanel, expectedGrid);
        }
    }
}
