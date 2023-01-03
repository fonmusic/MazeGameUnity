using System.IO;
using UnityEditor;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    [CustomEditor(typeof(SaveBonusesView))]
    public class SaveBonuses : Editor
    {
        private static XmlSerializer serializer;
        public List<Svect3> SaveBonusesT = new List<Svect3>();
        public Svect3[] bonusesPosition;
        //public List<Svect3> LoadBonusesT = new List<Svect3>();

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            SaveBonusesView saveBonusesView = (SaveBonusesView)target;

            if (serializer == null)
            {
                serializer = new XmlSerializer(typeof(Svect3[]));
            }

            if (GUILayout.Button("Save"))
            {
                if (saveBonusesView.bonuses.Count > 0)
                {
                    foreach (var item in saveBonusesView.bonuses)
                    {
                        if (!SaveBonusesT.Contains(item.position))
                        {
                            SaveBonusesT.Add(item.position);
                        }
                    }
                }
                using (FileStream fileStream = new FileStream(saveBonusesView.SavePath, FileMode.Create))
                {
                    serializer.Serialize(fileStream, SaveBonusesT.ToArray());
                }

                using (XmlTextReader reader = new XmlTextReader(saveBonusesView.SavePath))
                {
                    var LoadBonusesT =  serializer.Deserialize(reader);
                    bonusesPosition = (Svect3[])LoadBonusesT;

                    Vector3 position = bonusesPosition[0];
                    Debug.Log(position);
                }
            }
        }
    }
}