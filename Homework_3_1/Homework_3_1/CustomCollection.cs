using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1
{
    /// <summary>
    /// My collection.
    /// </summary>
    /// <typeparam name="T">Arbitrary type.</typeparam>
    internal sealed class CustomCollection<T> : IEnumerable<T>
        where T : IComparable<T>, IComparable
    {
        private T[] items;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollection{T}"/> class.
        /// </summary>
        /// <param name="items">Received array.</param>
        public CustomCollection(T[] items)
        {
            this.items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollection{T}"/> class.
        /// </summary>
        public CustomCollection()
        {
            this.items = new T[0];
        }

        /// <summary>
        /// Returns the length of the array.
        /// </summary>
        /// <returns>Lenght.</returns>
        public int Count()
        {
            return this.items.Length;
        }

        /// <summary>
        /// Adds a new element to the collection.
        /// </summary>
        /// <param name="newItem">Received item.</param>
        public void Add(T newItem)
        {
            T[] newArray = new T[this.items.Length + 1];
            for (int i = 0; i < this.items.Length; i++)
            {
                newArray[i] = this.items[i];
            }

            newArray[newArray.Length - 1] = newItem;
            this.items = newArray;
        }

        /// <summary>
        /// Sets default value at the certain position.
        /// </summary>
        /// <param name="index">Position index.</param>
        public void SetDefaultAt(int index)
        {
            T[] newArray = new T[this.items.Length];
            for (int i = 0; i < this.items.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = default(T);
                }
                else
                {
                    newArray[i] = this.items[i];
                }
            }

            this.items = newArray;
        }

        /// <summary>
        /// Sorts out the array by ascending.
        /// </summary>
        public void Sort()
        {
            for (int i = 0; i < this.items.Length; i++)
            {
                for (int j = 0; j < this.items.Length - 1; j++)
                {
                    if (this.items[j].CompareTo(this.items[j + 1]) > 0)
                    {
                        T extra = this.items[j];
                        this.items[j] = this.items[j + 1];
                        this.items[j + 1] = extra;
                    }
                }
            }
        }

        /// <returns>Iterator.</returns><summary>
        /// Implementation of IEnumerable.<T> using yield return.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.items)
            {
                yield return item;
            }
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
