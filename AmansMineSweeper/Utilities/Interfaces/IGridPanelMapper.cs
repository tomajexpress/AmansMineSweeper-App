using System.Collections.Generic;
using AmansMineSweeper.Model;
namespace AmansMineSweeper.Utilities
{
    public interface IGridPanelMapper
    {
        GridPanel MapArrayOfStringToGridPanel(string[] lines);

        List<string> MapGridPanelToArrayOfString(GridPanel gridPanel);
    }
}
