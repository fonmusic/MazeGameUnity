using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class GoodBonus : Bonus, IFly, IFlicker
    {

        public event Action<int> AddPoints = delegate (int i) { };

        [SerializeField] private Material _material;

        private int _point;


        public override void Awake()
        {
            base.Awake();
            //init bonus point, material, height fly
            
            _heightFly = UnityEngine.Random.Range(1.0f, 5.0f);

            _material = GetComponent<Renderer>().material;
            
        }


        public override void Execute()
        {
            Fly();
            Flick();
        }

        public void Flick()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _heightFly), transform.position.z);
        }

        

        protected override void Interaction()
        {
            IsInterctable = false;

            AddPoints?.Invoke(_point);
            
        }
    }
}