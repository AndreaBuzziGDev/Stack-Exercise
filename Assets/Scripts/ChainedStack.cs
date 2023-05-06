using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainedStack<T> : IStack<T>
{
    //DATA
    private ChainedStackItem<T> topChain;


    // METHODS

    //PUSH
    public override void Push(T myData)
    {
        topChain = new ChainedStackItem<T>(topChain, myData);
        size++;
    }

    //POP
    public override T Pop()//TODO: WHAT IS THE BEHAVIOUR OF A POPPED EMPTY STACK?
    {
        T topData = default(T);
        if (topChain != null)
        {
            topData = topChain.Data;
            topChain = topChain.PreviousItem;
            size--;
        }

        return topData;
    }

    //PEEK
    public override T Peek()
    {
        if (topChain != null)
        {
            return topChain.Data;
        }
        return default(T);
    }

    //ISEMPTY
    public override bool IsEmpty()
    {
        return topChain == null;
    }

}
