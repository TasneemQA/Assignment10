using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomListText : MonoBehaviour
{
    TasList<int> tasList = new TasList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
}
public class TasList<T> : IEnumerable<T>
{
    T[] _values = new T[4];
    int _count = 0;
    int _capacity = 4;
    public T this[int index]
    {
        get => _values[index];
    }
    public int Count
    {
        get => _count;
        private set => _count = value;
    }
    public int Capacity
    {
        get => _capacity;
        private set => _capacity = value;
    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
    public void Add(T v)
    {
        if (Capacity >= _values.Length)
        {
            T[] tempArr = new T[Capacity * 2];
            for (int i = 0; i < _values.Length; i++)
            {
                tempArr[i] = _values[i];
            }

            _values = tempArr;
            Capacity *= 2;
        }
        _values[Count++] = v;
    }
}
