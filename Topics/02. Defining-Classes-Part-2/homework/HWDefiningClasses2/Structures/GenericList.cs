using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class GenericList<T> where T : IComparable
    {
        private T[] array;
        private int lastIndex;

        public GenericList(int capacity)
        {
            this.array = new T[capacity];
            this.lastIndex = 0;
        }

        public void Add(T element)
        {
            this.Resize();
            this.array[lastIndex] = element;
            this.lastIndex++;
        }

        public void Remove(int index)
        {
            this.ValidateIndex(index);
            for (int i = index; i < this.lastIndex - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        public void Insert(int index, T element)
        {
            this.ValidateIndex(index);
            this.Resize();
            for (int i = lastIndex; i >= index; i--)
            {
                this.array[i + 1] = this.array[i];
            }
            this.array[index] = element;
            this.lastIndex++;
        }

        public void Clear()
        {
            this.lastIndex = 0;
        }

        public int Find(T searchedValue)
        {
            for (int i = 0; i <= this.lastIndex; i++)
            {
                if (this.array[i].CompareTo(searchedValue) == 0)
                    return i;
            }

            return -1;
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.array[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.array[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.lastIndex; i++)
            {
                builder.AppendFormat("{0}; ", this.array[i]);
            }

            return builder.ToString();
        }

        public T Max()
        {
            return this.array.Max();
        }

        public T Min()
        {
            T min = this.array[0];
            for (int i = 1; i < this.lastIndex; i++)
            {
                if (this.array[i].CompareTo(min) > 0) min = this.array[i];
            }

            return min;
        }
        private void ValidateIndex(int index)
        {
            if (index < 0 || index > this.lastIndex)
            {
                throw new IndexOutOfRangeException("Index is out of possible values");
            }
        }

        private void Resize()
        {
            if (this.lastIndex < this.array.Length - 1)
            {
                return;
            }
            T[] newArray = new T[2 * this.array.Length];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
    }
}
