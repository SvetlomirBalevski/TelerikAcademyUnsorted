using System;
using System.Text;

namespace HWDeffClass2
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        private T[] _Elements;
        private int _ListCapacity;
        private int _Count;

        public GenericList(int ListCapacity)
        {
            if (validator(ListCapacity))
            {
                this._ListCapacity = ListCapacity;
                this._Elements = new T[ListCapacity];
                this._Count = 0;
            }
        }

        //We don't want to set the size of list after it's creation by Constructor, but we want to check it
        public int Capacity
        {
            get
            {
                return this._ListCapacity;
            }
        }

        public void Add(T valueToAdd)
        {

            if (CheckForSpaceInArray() == false)
            {
                AutoGrow();
            }
            this._Elements[this._Count] = valueToAdd;
            this._Count++;
        }

        public T ElementAt(int index)
        {
            CheckForIndex(index);
            return this._Elements[index];
        }

        public void RemoveElementAt(int index)
        {
            CheckForIndex(index);
            this._Elements[index] = default(T);
        }

        public void InsertElementAt(int index, T value)
        {
            while (!CheckForSpaceInArray())
            {
                AutoGrow();
            }

            T[] temp = new T[_Elements.Length + 1];
            for (int i = index; i < this._Count; i++)
            {
                temp[i + 1] = this._Elements[i];
            }
            _Elements[index] = value;
            for (int i = index + 1; i < _Elements.Length; i++)
            {
                this._Elements[i] = temp[i];
            }
        }

        private bool validator(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Plesase enter a Positive value");
            }
            return true;
        }

        private bool CheckForSpaceInArray()
        {
            if (this._Count >= this._Elements.Length)
            {
                return false;
            }
            return true;
        }

        public void Clear()
        {
            for (int i = 0; i < this._Elements.Length; i++)
            {
                this._Elements[i] = default(T);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this._Elements)
            {
                sb.AppendFormat($"{item} ");
            }
            return sb.ToString().TrimEnd();
        }

        private void AutoGrow()
        {
            T[] temp = new T[this._Elements.Length * 2];
            for (int i = 0; i < this._Elements.Length; i++)
            {
                temp[i] = this._Elements[i];
            }
            this._Elements = temp;
        }

        private void CheckForIndex(int index)
        {
            if (index > this._Elements.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("This index did not exict");
            }
        }

        public int FindElementByValue(T value)
        {
            for (int i = 0; i < this._Count; i++)
            {
                if (this._Elements[i].Equals(value))
                {
                    return i;
                }
            }
            return 0;
        }

        public T Min()
        {
            T min = this._Elements[0];
            for (int i = 0; i < this._Count; i++)
            {
                if (min.CompareTo(this._Elements[i]) > 0)
                {
                    min = this._Elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this._Elements[0];
            for (int i = 0; i < this._Count; i++)
            {
                if (max.CompareTo(this._Elements[i]) < 0)
                {
                    max = this._Elements[i];
                }
            }
            return max;
        }
    }
}