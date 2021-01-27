using System.IO;
using AmansMineSweeper.Model;

namespace AmansMineSweeper.Utilities
{
    public class GridPanelTextFileLoader : IGridPanelLoader
    {
        private readonly string _path;

        private readonly IGridPanelMapper _gridPanelMapper;

        public GridPanelTextFileLoader(string path, IGridPanelMapper gridPanelMapper)
        {
            _path = path;

            _gridPanelMapper = gridPanelMapper;
        }

        public GridPanel LoadGridPanel()
        {
            var lines = File.ReadAllLines(_path);

            return _gridPanelMapper.MapArrayOfStringToGridPanel(lines);
        }

    }
}
