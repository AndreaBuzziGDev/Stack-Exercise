using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //DATA
    static StackController SC;

    //METHODS
    //TECHNICAL
    private void Start()
    {
        SC = FindObjectOfType<StackController>();
    }


    //FUNCTIONALITIES
    public static void Add()
    {
        SC.AddToStackRandomly();
    }

    public static void Pop()
    {
        SC.PopStack();
    }

    public static void Peek()
    {
        SC.PeekStack();
    }

    public static void IsEmpty()
    {
        SC.CheckIsEmpty();
    }

    public static void Size()
    {
        SC.CheckSize();
    }

}
