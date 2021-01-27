using AmansMineSweeper.Constants;
using AmansMineSweeper.Model;
using AmansMineSweeper.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmansMineSweeper.UnitTest
{
    [TestClass]
    public class AdjacentCalculatorTests
    {
        [TestMethod]
        public void CalculateBelowAdjacent_FindsTheBelowLocationAndIncrementsTheLocationValue_SetsTheGridPanelToNewCorrectStatus()
        {
            // arrange

            var actualGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, 0, 0 }, 
                { 0, 0, GridPanelConstantValues.Mine }
            };

            var actualGridPanel = new GridPanel(2,3);
            
            TestTool.ArrangeInputs(actualGridPanel, actualGrid);

            // act

            IAdjacentCalculator adjacentCalculator = new AdjacentCalculator(actualGridPanel);
            
            adjacentCalculator.CalculateBelowAdjacent(new Location{ Row = 0, Column = 0});

            // assert

            var expectedGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, 0, 0 }, 

                { 1, 0, GridPanelConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualGridPanel, expectedGrid);
        }

        [TestMethod]
        public void CalculateRightAdjacent_FindsTheRightLocationAndIncrementsTheLocationValue_SetsTheGridPanelToNewCorrectStatus()
        {
            // arrange

            var actualGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, 0, 0 }, 
                { 0, 0, GridPanelConstantValues.Mine }
            };

            var actualGridPanel = new GridPanel(2, 3);

            TestTool.ArrangeInputs(actualGridPanel, actualGrid);

            // act

            IAdjacentCalculator adjacentCalculator = new AdjacentCalculator(actualGridPanel);

            adjacentCalculator.CalculateRightAdjacent(new Location { Row = 0, Column = 0 });

            // assert

            var expectedGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, 1, 0 }, 

                { 0, 0, GridPanelConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualGridPanel, expectedGrid);
        }

        [TestMethod]
        public void CalculateLeftAdjacent_FindsTheLeftLocationAndIncrementsTheLocationValue_SetsTheGridPanelToNewCorrectStatus()
        {
            // arrange

            var actualGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, 0, 0 }, 
                { 0, 0, GridPanelConstantValues.Mine }
            };

            var actualGridPanel = new GridPanel(2, 3);

            TestTool.ArrangeInputs(actualGridPanel, actualGrid);

            // act

            IAdjacentCalculator adjacentCalculator = new AdjacentCalculator(actualGridPanel);

            adjacentCalculator.CalculateLeftAdjacent(new Location { Row = 1, Column = 2 });

            // assert

            var expectedGrid = new int[,]
            {
                { GridPanelConstantValues.Mine, 0, 0 }, 

                { 0, 1, GridPanelConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualGridPanel, expectedGrid);
        }
    }
}
