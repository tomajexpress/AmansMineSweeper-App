using System;
using AmansMineSweeper.Model;

namespace AmansMineSweeper.Utilities
{
    public class LoggerConsole : ILogger
    {
        private readonly IGridPanelMapper _gridPanelMapper;

        public LoggerConsole(IGridPanelMapper gridPanelMapper)
        {
            _gridPanelMapper = gridPanelMapper;
        }

        public void Log(GridPanel gridPanel)
        {
            var strings = _gridPanelMapper.MapGridPanelToArrayOfString(gridPanel);

            foreach (var line in strings)
            {
                Console.WriteLine(line);
            }
        }
    }
}
