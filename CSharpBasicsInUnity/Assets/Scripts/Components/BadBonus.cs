using System;
using UnityEngine;

namespace Maze
{

    public class BadBonus : Bonus, IFly, IRotation
    {
        private float speedRotation;

        public event Action<string, Color> OnCaughtPlayer = delegate (string str, Color color) { };

        public override void Awake()
        {
            _heightFly = UnityEngine.Random.Range(1.0f, 5.0f);
            speedRotation = UnityEngine.Random.Range(13f, 40f);
        }

        public override void Execute()
        {
            Fly();
            Rotate();
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _heightFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation), Space.World);
        }

        protected override void Interaction()
        {
            OnCaughtPlayer.Invoke(gameObject.name, _color);
        }
    }
}
