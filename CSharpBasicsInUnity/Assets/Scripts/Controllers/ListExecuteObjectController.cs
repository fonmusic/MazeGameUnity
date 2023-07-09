using System.Collections;
using System;

namespace Maze
{
    public class ListExecuteObjectController : IEnumerable, IEnumerator
    {
        private int _index = -1;
        private IExecute[] _executeObjects;

        public int Length { get { return _executeObjects.Length; } }

        public object Current => _executeObjects[_index];

        public IExecute this [int curr] 
        {
            get => _executeObjects[curr];
            set => _executeObjects[curr] = value;
        }

        public ListExecuteObjectController(Bonus[] bonuses)
        {
            for (int i = 0; i < bonuses.Length; i++)
            {
                if (bonuses[i] is IExecute execute)
                    AddExecuteObject(execute);
            }
        }

        public void AddExecuteObject(IExecute executeObject)
        {
            if (_executeObjects == null)
            {
                _executeObjects = new[] { executeObject };
                return;
            }
            Array.Resize(ref _executeObjects, Length + 1);
            _executeObjects[Length - 1] = executeObject;
        }
        
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_index == Length - 1)
                return false;
            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}