using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListStack<T> : IStack<T>
{
    //DATA
    private List<T> myStackAsList = new List<T>();

    public override int Size { get { return myStackAsList.Count; } }


    // METHODS

    //PUSH
    public override void Push(T myData)
    {
        myStackAsList.Add(myData);
    }

    //POP
    public override T Pop()//TODO: WHAT IS THE BEHAVIOUR OF A POPPED EMPTY STACK?
    {
        T topData = default(T);
        if (myStackAsList.Count > 0)
        {
            topData = myStackAsList[myStackAsList.Count - 1];
            myStackAsList.RemoveAt(myStackAsList.Count - 1);
        }

        return topData;
    }

    //PEEK
    public override T Peek()
    {
        T topData = default(T);
        if (myStackAsList.Count > 0)
        {
            topData = myStackAsList[myStackAsList.Count - 1];
        }

        return topData;
    }

    //ISEMPTY
    public override bool IsEmpty()
    {
        return myStackAsList.Count == 0;
    }

}
