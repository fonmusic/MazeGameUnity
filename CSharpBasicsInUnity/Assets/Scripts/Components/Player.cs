using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public struct PlayerData
    {
        public string Name;
        public Vector3 Position;
        public Quaternion Rotation;
        public int Health;
        public bool PlayerDead;

        public PlayerData (Player player)
        {
            Name = player.name;
            Position = player.transform.position;
            Rotation = player.transform.rotation;
            Health = player.Health;
            PlayerDead = player.IsDead;
        }
    }

    public class Player : Unit
    {
        public PlayerData _playerData;
        private ISaveData _saveData;

        public Transform PlayerDot;

        public override void Awake()
        {
            base.Awake();
            Health = 100;

            _saveData = new JSONData();
            //_saveData = new StreamData();

            _playerData = new PlayerData(this);
            _saveData.SaveData(_playerData);

            PlayerData tempPlayerData = new PlayerData();
            tempPlayerData = _saveData.Load();

            //Debug.Log(tempPlayerData.Health);
            //Debug.Log(tempPlayerData.Position);
            //Debug.Log(tempPlayerData.Rotation);
            //Debug.Log(tempPlayerData.PlayerDead);
        }

        public override void Move(float x, float y, float z)
        {
            PlayerDot.position = new Vector3(_transform.position.x, PlayerDot.position.y, _transform.position.z);

            if (_rigidbody)
            {
                _rigidbody.AddForce(new Vector3(x, y, z) * Speed);
            }
        }
    }
}