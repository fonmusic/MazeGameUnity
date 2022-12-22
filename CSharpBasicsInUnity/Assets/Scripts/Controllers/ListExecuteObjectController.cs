using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;

namespace Maze
{
    public class ListExecuteObjectController
    {
        private IExecute[] _executeObjects;

        public int Length { get { return _executeObjects.Length; } }

        public IExecute[] ExecuteObjects { get => _executeObjects; set => _executeObjects = value; }

        public ListExecuteObjectController(Bonus[] bonuses)
        {
            for (int i = 0; i < bonuses.Length; i++)
            {
                if (bonuses[i] is IExecute intObject)
                    AddExecuteObject(intObject);
            }
        }

        public void AddExecuteObject(IExecute executeObject)
        {
            if (ExecuteObjects == null)
            {
                ExecuteObjects = new[] { executeObject };
                return;
            }
            Array.Resize(ref _executeObjects, Length + 1);
            ExecuteObjects[Length - 1] = executeObject;
        }
    }
}