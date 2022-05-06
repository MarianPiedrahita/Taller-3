using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugIndex : MonoBehaviour
{

    ChangeColor changeColor;

    void Start()
    {
        changeColor = FindObjectOfType<ChangeColor>();

        ColorChanger.OnButtonClicked += PrintNumber;
    }

   
    private void PrintNumber()
    {
        if (changeColor.index == 4)
        {
            changeColor.index = 0;
        }

        Debug.Log(changeColor.index + 1);
    }



    private void OnDisable()
    {
        ColorChanger.OnButtonClicked -= PrintNumber;
    }
}