using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainedStackItem<T>
{
    //DATA
    T data;
    public T Data {get { return data;} }

    ChainedStackItem<T> previousItem;
    public ChainedStackItem<T> PreviousItem { get { return previousItem; } }



    //METHODS
    public ChainedStackItem(ChainedStackItem<T> _prevItem, T _data)
    {
        data = _data;
        previousItem = _prevItem;
    }

}

