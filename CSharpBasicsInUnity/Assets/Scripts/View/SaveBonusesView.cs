using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

#if UNITY_EDITOR
namespace Maze
{
    public class SaveBonusesView : MonoBehaviour
    {
        public List<Transform> bonuses = new List<Transform>();
        private string savePath;
        public string directoryName;
        public string sceneName;

        public string SavePath { get => savePath; set => savePath = value; }

        private void OnDrawGizmos()
        {
            sceneName = EditorSceneManager.GetActiveScene().name;
            directoryName = "Bonuses Data";
            savePath = Path.Combine(Application.dataPath+"/"+directoryName, "BonusesData_"+sceneName+".xml");
        }
    }
}
#endif