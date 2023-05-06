using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    //ENUMS
    public enum eStackType
    {
        chain,
        list,
        none
    }

    //DATA
    [SerializeField] eStackType StackType;

    private IStack<float> StackInstance;


    //METHODS
    //START: INIZIALIZZA STACK
    private void Start()
    {
        StackInstance = GetMappedStack(StackType);
        Debug.Log("Initialized Stack, type: " + StackType);
    }

    //UPDATE: NO NEED?

    //FUNCTIONALITIES
    //THESE ARE FUNCTIONALITIES THAT WRAP STACK IMPLEMENTATIONS AND THAT CAN BE CALLED FROM Mono ITEMS
    public void AddToStackRandomly()
    {
        float myRandomVal = Random.Range(0.1f, 10.0f);

        if (StackInstance != null)
        {
            StackInstance.Push(myRandomVal);
            Debug.Log("Current Stack Size: " + StackInstance.Size);
        }
        else
        {
            Debug.Log("Stack is null, cannot Add.");
        }
    }

    public float PopStack()
    {

        if (StackInstance != null)
        {
            float poppedValue = StackInstance.Pop();
            Debug.Log("Current Popped Value: " + poppedValue);
            Debug.Log("Current Stack Size: " + StackInstance.Size);

            return poppedValue;
        }
        else
        {
            Debug.Log("Stack is null, cannot Pop.");
            return 0.0f;
        }
    }

    public float PeekStack()
    {
        if (StackInstance != null)
        {
            float peekedValue = StackInstance.Peek();
            Debug.Log("Current Peeked Value: " + peekedValue);
            Debug.Log("Current Stack Size: " + StackInstance.Size);

            return peekedValue;
        }
        else
        {
            Debug.Log("Stack is null, cannot Peek.");
            return 0.0f;
        }
    }

    public bool CheckIsEmpty()
    {
        if (StackInstance != null)
        {
            bool empty = StackInstance.IsEmpty();
            Debug.Log("Is stack empty: " + empty);
            return empty;
        }
        else
        {
            Debug.Log("Stack is null, cannot Peek.");
            return false;
        }
    }
    public int CheckSize()
    {
        if (StackInstance != null)
        {
            int size = StackInstance.Size;
            Debug.Log("Stack size: " + size);
            return size;
        }
        else
        {
            Debug.Log("Stack is null, cannot check size.");
            return 0;
        }
    }




    //UTILITIES

    //GET CORRESPONDING STACK TYPE
    public IStack<float> GetMappedStack(eStackType stackType)
    {
        IStack<float> result;

        switch (stackType)
        {
            case eStackType.chain:
                result = new ChainedStack<float>();
                break;
            default:
                result = null;
                break;
        }

        return result;
    }

}
