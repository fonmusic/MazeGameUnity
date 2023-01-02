using System;
using System.IO;
using UnityEngine;

namespace Maze
{
    public class StreamData : ISaveData
    {
        string SavePatch = Path.Combine(Application.dataPath, "STREAMData.xyz");

        public void SaveData(PlayerData playerData)
        {
            using (StreamWriter sw = new StreamWriter(SavePatch))
            {
                sw.WriteLine(playerData.Name);
                sw.WriteLine(playerData.Health);
                sw.WriteLine(playerData.Position);
                sw.WriteLine(playerData.Rotation);
                sw.WriteLine(playerData.PlayerDead);
            }
        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();
            if (!File.Exists(SavePatch))
            {
                Debug.Log("File not exist");
                return result;
            }
            using (StreamReader sr = new StreamReader(SavePatch))
            {
                result.Name = sr.ReadLine();
                result.Health = Convert.ToInt32(sr.ReadLine());
                result.PlayerDead = Convert.ToBoolean(sr.ReadLine());
            }
            return result;
        }

        public void SaveDataBonuses(BonusData bonusData)
        {
            throw new NotImplementedException();
        }

        public BonusData LoadBonuses()
        {
            throw new NotImplementedException();
        }
    }
}