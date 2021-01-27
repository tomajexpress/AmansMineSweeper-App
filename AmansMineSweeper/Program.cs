using System;
using AmansMineSweeper.Model;
using AmansMineSweeper.Service;
using AmansMineSweeper.Utilities;

namespace AmansMineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the full filePath and fileName :");

            var filePath = Console.ReadLine();

            var gridPanel = GetGridPanel(filePath);

            IMineSweeperService meinSweeperService = new MineSweeperService(new AdjacentCalculator(gridPanel));

            meinSweeperService.CalculateAdjacentValues(gridPanel);

            LogGridPanel(gridPanel);

            Console.ReadKey();
        }

        private static void LogGridPanel(GridPanel gridPanel)
        {
            ILogger logger = new LoggerConsole(new GridPanelMapper());

            logger.Log(gridPanel);
        }

        private static GridPanel GetGridPanel(string filePath)
        {
            IGridPanelLoader gridLoder = new GridPanelTextFileLoader(filePath, new GridPanelMapper());

            return gridLoder.LoadGridPanel();
        }
    }
}
