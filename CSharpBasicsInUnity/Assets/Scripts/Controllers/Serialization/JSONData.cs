using System.IO;
using UnityEngine;

namespace Maze
{
    //public class JSONData<T> : ISaveData<T>
    //{
    //    string SavePatch = Path.Combine(Application.dataPath, "JSONData.json");

    //    public void SaveData(T playerData)
    //    {
    //        string FileJson = JsonUtility.ToJson(playerData);
    //        File.WriteAllText(SavePatch, FileJson);
    //    }

    //    public T Load()
    //    {
    //        PlayerData result = new PlayerData();
    //        if (!File.Exists(SavePatch))
    //        {
    //            Debug.Log("File not exist");
    //            return result;
    //        }

    //        string json = File.ReadAllText(SavePatch);
    //        result = JsonUtility.FromJson<PlayerData>(json);

    //        return result;
    //    }
    //}


    public class JSONData : ISaveData
    {
        string SavePatch = Path.Combine(Application.dataPath, "JSONData.json");
        string SavePatch2 = Path.Combine(Application.dataPath, "JSONDataBonuses.json");


        public void SaveData(PlayerData playerData)
        {
            string FileJson = JsonUtility.ToJson(playerData);
            File.WriteAllText(SavePatch, FileJson);
        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();
            if (!File.Exists(SavePatch))
            {
                Debug.Log("File not exist");
                return result;
            }

            string json = File.ReadAllText(SavePatch);
            result = JsonUtility.FromJson<PlayerData>(json);

            return result;
        }

        public void SaveDataBonuses(BonusData bonusData)
        {
            string FileJson = JsonUtility.ToJson(bonusData);
            File.WriteAllText(SavePatch2, FileJson);
        }

        public BonusData LoadBonuses()
        {
            BonusData result = new BonusData();
            if (!File.Exists(SavePatch2))
            {
                Debug.Log("File not exist");
                return result;
            }

            string json = File.ReadAllText(SavePatch2);
            result = JsonUtility.FromJson<BonusData>(json);

            return result;
        }
    }
}