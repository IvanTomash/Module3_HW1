using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1
{
    /// <summary>
    /// Used for creating person.
    /// </summary>
    internal sealed class Person : IComparable<Person>, IComparable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="id">Person's id.</param>
        /// <param name="name">Person's name.</param>
        public Person(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets person's id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets person's name.
        /// </summary>
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{this.ID}\t{this.Name}";
        }

        /// <inheritdoc/>
        public int CompareTo(Person other)
        {
            if (this.ID < other.ID)
            {
                return -1;
            }
            else if (this.ID > other.ID)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <inheritdoc/>
        public int CompareTo(object obj)
        {
            Person extra = obj as Person;
            if (extra is Person)
            {
                if (this.ID < extra.ID)
                {
                    return -1;
                }
                else if (this.ID > extra.ID)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return this.ID == otherPerson.ID;
            }

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}
