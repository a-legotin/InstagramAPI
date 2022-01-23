using System.Collections;
using System.Collections.Generic;
using System.Linq;
using InstaSharper.Abstractions.Models;
using InstaSharper.Abstractions.Models.User;

namespace InstaSharper.Models.User;

internal class InstaUserShortList : IInstaList<InstaUserShort>
{
    private readonly List<InstaUserShort> _innerList = new();

    public InstaUserShortList()
    {
    }

    public InstaUserShortList(IEnumerable<InstaUserShort> users)
    {
        _innerList.AddRange(users);
    }

    public string NextMaxId { get; set; }

    public IEnumerator<InstaUserShort> GetEnumerator()
    {
        return _innerList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(InstaUserShort item)
    {
        _innerList.Add(item);
    }

    public void Clear()
    {
        _innerList.Clear();
    }

    public bool Contains(InstaUserShort item)
    {
        return _innerList.Any(user => user.Pk == item?.Pk);
    }

    public void CopyTo(InstaUserShort[] array,
                       int arrayIndex)
    {
        _innerList.CopyTo(array, arrayIndex);
    }

    public bool Remove(InstaUserShort item)
    {
        return _innerList.Remove(item);
    }

    public int Count => _innerList.Count;

    public bool IsReadOnly => false;

    public int IndexOf(InstaUserShort item)
    {
        return _innerList.IndexOf(item);
    }

    public void Insert(int index,
                       InstaUserShort item)
    {
        _innerList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        _innerList.RemoveAt(index);
    }

    public InstaUserShort this[int index]
    {
        get => _innerList[index];
        set => _innerList[index] = value;
    }

    public void AddRange(IEnumerable<InstaUserShort> items)
    {
        _innerList.AddRange(items);
    }
}