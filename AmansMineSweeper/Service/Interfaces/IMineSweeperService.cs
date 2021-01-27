using AmansMineSweeper.Model;

namespace AmansMineSweeper.Service
{
    public interface IMineSweeperService
    {
        void CalculateAdjacentValues(GridPanel gridPanel);
    }
}
