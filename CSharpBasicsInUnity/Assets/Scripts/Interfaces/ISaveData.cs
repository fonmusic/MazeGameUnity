namespace Maze
{
    public interface ISaveData
    {
        void SaveData(PlayerData playerData);

        PlayerData Load();

        void SaveDataBonuses(BonusData bonusData);

        BonusData LoadBonuses();
    }
}