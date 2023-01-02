namespace Maze
{
    //public interface ISaveData<T>
    //{
    //    void SaveData(T data);

    //    T Load();
    //}

    public interface ISaveData
    {
        void SaveData(PlayerData playerData);

        PlayerData Load();

        void SaveDataBonuses(BonusData bonusData);

        BonusData LoadBonuses();
    }
}