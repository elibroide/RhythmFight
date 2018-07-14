using RhythmFight.Data;

namespace RhythmFight.Models
{
    public class PlayerModel
    {
        public Value<PlayerStatsModel> stats;
        public Value<PlayerAction> nextAction;
        public Value<int> currentHealth;
    }
}