using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    //public struct BonusData
    //{
    //    public string Name;
    //    public Vector3 Position;
    //    public Quaternion Rotation;

    //    public BonusData(LevelObjectView levelObjectView)
    //    {
    //        Name = levelObjectView.name;
    //        Position = levelObjectView.transform.position;
    //        Rotation = levelObjectView.transform.rotation;
    //    }
    //}

    public class LevelObjectView : MonoBehaviour
    {
        //public BonusData _bonusData;
        //private ISaveData _saveData;


        [SerializeField] private Transform _transform;
        [SerializeField] private Collider _collider;
        [SerializeField] private Renderer _renderer;

        public Transform _Transform { get => _transform; set => _transform = value; }
        public Collider _Collider { get => _collider; set => _collider = value; }
        public Renderer _Renderer { get => _renderer; set => _renderer = value; }

        //void Awake()
        //{
        //    if (!TryGetComponent<Transform>(out _Transform))
        //    {
        //        Debug.Log("No Transform component");
        //    }
        //    if (!TryGetComponent<Renderer>(out Renderer))
        //    {
        //        Debug.Log("No Renderer component");
        //    }

        //    if (!TryGetComponent<Collider>(out Collider))
        //    {
        //        Debug.Log("No Collider component");
        //    }
        //}
        //public void Awake()
        //{
        //    _saveData = new JSONData();

        //    _bonusData = new BonusData(this);
        //    _saveData.SaveDataBonuses(_bonusData);

        //    BonusData tempBonusData = new BonusData();
        //    tempBonusData = _saveData.LoadBonuses();

        //    Debug.Log(tempBonusData.Name);
        //    Debug.Log(tempBonusData.Position);
        //    Debug.Log(tempBonusData.Rotation);
        //}


    }
}