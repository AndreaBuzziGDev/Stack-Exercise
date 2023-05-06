using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IStack<T>
{
    //SIZE
    protected int size = 0;
    public int Size { get { return size; } }

    //PUSH
    public abstract void Push(T myData);//TODO: USE GENERALIZATION

    //POP
    public abstract T Pop();//TODO: USE GENERALIZATION

    //PEEK
    public abstract T Peek();//TODO: USE GENERALIZATION

    //ISEMPTY
    public abstract bool IsEmpty();

}
