using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class GoodBonus : Bonus, IFly, IFlicker
    {

        [SerializeField] private Material _material;


        public override void Awake()
        {
            base.Awake();
            //init bonus point, material, height fly
            
            _heightFly = Random.Range(1.0f, 5.0f);

            _material = GetComponent<Renderer>().material;
            
        }


        public override void Execute()
        {
            Fly();
            //fly
            //flick
        }

        public void Flicker()
        {
            //throw new System.NotImplementedException();
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _heightFly), transform.position.z);
        }

        

        protected override void Interaction()
        {
            IsInterctable = false;
            
            //Add point
        }
    }
}