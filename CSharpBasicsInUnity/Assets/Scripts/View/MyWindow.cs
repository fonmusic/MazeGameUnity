using UnityEditor;
using UnityEngine;

namespace Maze
{
    public class MyWindow : EditorWindow
    {
        public static GameObject ObjectInstantiate;
        public string _nameObject = "Bonus";
        public bool _groupEnabled;
        public bool _randomColor = true;
        public int _countObject = 1;
        public float _radius = 10;

        private void OnGUI()
        {
            GUILayout.Label("Main preferences", EditorStyles.boldLabel);
            ObjectInstantiate = EditorGUILayout.ObjectField("Object that we create", ObjectInstantiate, typeof(GameObject), true) as GameObject;
            _nameObject = EditorGUILayout.TextField("Object's name", _nameObject);
            _groupEnabled = EditorGUILayout.BeginToggleGroup("Additional preferences", _groupEnabled);
            _randomColor = EditorGUILayout.Toggle("Random color", _randomColor);
            _countObject = EditorGUILayout.IntSlider("Number of objects", _countObject, 1, 100);
            _radius = EditorGUILayout.Slider("Radius of a circle", _radius, 10, 50);
            EditorGUILayout.EndToggleGroup();
            var button = GUILayout.Button("Create objects");
            if (button)
            {
                if (ObjectInstantiate)
                {
                    GameObject root = new GameObject("Root");
                    for (int i = 0; i < _countObject; i++)
                    {
                        float angle = i * Mathf.PI * 2 / _countObject;
                        Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * _radius;
                        GameObject temp = Instantiate(ObjectInstantiate, pos, Quaternion.identity);
                        temp.name = _nameObject + "(" + i + ")";
                        temp.transform.parent = root.transform;
                        var tempRenderer = temp.GetComponent<Renderer>();
                        if (tempRenderer && _randomColor)
                        {
                            tempRenderer.material.color = Random.ColorHSV();
                        }
                    }
                }
            }
        }
    }
}