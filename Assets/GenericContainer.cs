using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<ItemType> : IList<ItemType>
{
    List<ItemType> Data = new();

    public ItemType this[int index] { get => Data[index]; set => Data[index] = value; }

    public int Count => Data.Count;

    public bool IsReadOnly => false;

    public void Add(ItemType item)
    {
        Data.Add(item);
    }

    public void Add<LocalType>(LocalType item) where LocalType : MonoBehaviour, ItemType
    {
        Debug.Log((item as MonoBehaviour).name);

        Data.Add(item);
    }

    //public void Add(float item)
    //{
    //    (Data as List<float>).Add(item * 100f);
    //}

    public void Clear()
    {
        Data.Clear();
    }

    public bool Contains(ItemType item)
    {
        return Data.Contains(item);
    }

    public void CopyTo(ItemType[] array, int arrayIndex)
    {
        Data.CopyTo(array, arrayIndex);
    }

    public IEnumerator<ItemType> GetEnumerator()
    {
        return Data.GetEnumerator();
    }

    public int IndexOf(ItemType item)
    {
        return Data.IndexOf(item);
    }

    public void Insert(int index, ItemType item)
    {
        Data.Insert(index, item);
    }

    public bool Remove(ItemType item)
    {
        return Data.Remove(item);
    }

    public void RemoveAt(int index)
    {
        Data.RemoveAt(index);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return Data.GetEnumerator();
    }
}
