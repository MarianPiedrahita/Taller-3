using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugIndex : MonoBehaviour
{

    ChangeColor changeColor;
    [SerializeField] Text indexText;

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
        indexText.text = (changeColor.index + 1).ToString();
    }



    private void OnDisable()
    {
        ColorChanger.OnButtonClicked -= PrintNumber;
    }
}