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
        private int _point = 1;
        private LevelObjectView _levelObjectView;


        public GoodBonus(LevelObjectView levelObjectView) : base(levelObjectView)
        {
            _levelObjectView = levelObjectView;
            Init();
        }

        public void Init()
        {
            
            
            _heightFly = UnityEngine.Random.Range(1.0f, 5.0f);

            _material = _levelObjectView._Renderer.material;
            
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
            _levelObjectView._Transform.position = new Vector3(_levelObjectView._Transform.position.x, Mathf.PingPong(Time.time, _heightFly), _levelObjectView._Transform.position.z);
        }

        

        protected override void Interaction()
        {
            IsInterctable = false;

            AddPoints.Invoke(_point);
            
        }
    }
}