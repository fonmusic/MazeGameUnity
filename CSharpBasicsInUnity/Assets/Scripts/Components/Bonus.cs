using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Maze
{
    public struct BonusData
    {
        public string Name;
        public Vector3 Position;
        public Quaternion Rotation;
        public bool Interectable;

        public BonusData(Bonus bonus)
        {
            Name = bonus.name;
            Position = bonus.transform.position;
            Rotation = bonus.transform.rotation;
            Interectable = bonus.IsInterctable;
        }
    }

    public abstract class Bonus : MonoBehaviour, IExecute
    {
        public BonusData _bonusData;
        private ISaveData _saveData;


        private bool _isInterctable;
        protected Color _color;
        private Renderer _renderer;
        private Collider _collider;
        public float _heightFly;

        public bool IsInterctable
        {
            get => _isInterctable;
            set
            {
                _isInterctable = value;
                BonusRenderer.enabled = value;
                _collider.enabled = value;
            }
        }

        public Renderer BonusRenderer { get => _renderer; set => _renderer = value; }

        public virtual void Awake()
        {
            //BonusRenderer = GetComponent<Renderer>();

            if (!TryGetComponent<Renderer>(out _renderer))
            {
                Debug.Log("No Renderer component");
            }

            if (!TryGetComponent<Collider>(out _collider))
            {
                Debug.Log("No Collider component");
            }

            IsInterctable = true;
            _color = Random.ColorHSV();
            BonusRenderer.sharedMaterial.color = _color;

            _saveData = new JSONData();

            _bonusData = new BonusData(this);
            _saveData.SaveDataBonuses(_bonusData);

            BonusData tempBonusData = new BonusData();
            tempBonusData = _saveData.LoadBonuses();

            Debug.Log(tempBonusData.Name);
            Debug.Log(tempBonusData.Position);
            Debug.Log(tempBonusData.Rotation);
            Debug.Log(tempBonusData.Interectable);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
            }
        }

        protected abstract void Interaction();

        public abstract void Execute();
    }
}