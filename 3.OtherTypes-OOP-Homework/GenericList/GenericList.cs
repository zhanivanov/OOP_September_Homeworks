using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenericList<T> where T: IComparable<T>
{
    private const int defaultCapacity = 16;

    private T[] list;
    private int count = 0;

    public GenericList(int capacity = defaultCapacity)
    {
        list = new T[capacity];
    }

    public int Capacity 
    {
        get { return this.list.Length; }
    }

    public int Count
    {
        get { return this.count; }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return list[index];
        }
    }

    public void Add(T element)
    {
        if (this.Count >= this.Capacity)
        {
            this.Expand();
        }
        this.list[count] = element;
        this.count++;
    }

    public int IndexOf(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (element.Equals(list[i]))
            {
                return i;
            }
        }

        return -1;
    }

    public bool Contains(T element)
    {
        if (this.IndexOf(element) == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void InsertAt(int position, T element)
    {
        if(position < 0 || position > this.Count)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (this.Count >= this.Capacity)
        {
            this.Expand();
        }

        for (int i = this.Count; i > position; i--)
        {
            this.list[i] = this.list[i - 1];
        }
        this.count++;
        list[position] = element;
        
    }

    public void RemoveAt(int position)
    {
        if (position < 0 || position > this.Count)
        {
            throw new ArgumentOutOfRangeException();
        }

        for (int i = position; i < this.count - 1; i++)
        {
            this.list[i] = this.list[i + 1];
        }

        this.count--;
        this.list[count] = default(T);
    }

    public void Clear()
    {
        this.list = new T[this.Capacity];
        this.count = 0;
    }

    public T Min()
    {
        if (this.count < 1)
        {
            throw new InvalidOperationException("The list is empty");
        }
        T min = this.list[0];
        for (int i = 1; i < this.count; i++)
        {
            if (this.list[i].CompareTo(min) < 0)
            {
                min = list[i];
            }
        }

        return min;
    }

    public T Max()
    {
        if (this.count < 1)
        {
            throw new InvalidOperationException("The list is empty");
        }
        T max = this.list[0];
        for (int i = 1; i < this.count; i++)
        {
            if (this.list[i].CompareTo(max) > 0)
            {
                max = list[i];
            }
        }

        return max;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder(this.count);
        for (int i = 0; i < this.count; i++)
        {
            result.Append(list[i] + ", ");
        }

        return result.ToString().Trim(' ', ',');
    }

    private void Expand()
    {
        T[] expandedList = new T[this.Capacity * 2];
        this.list.CopyTo(expandedList, 0);
        this.list = expandedList;
    }
}