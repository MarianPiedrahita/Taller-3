using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
   
    [SerializeField] Color[] colors = new Color[4];


    public int index;
    Renderer squareRenderer;
    void Start()
    {
        index = 0;
        squareRenderer = GetComponent<Renderer>();

        ColorChanger.OnButtonClicked += ChangeColorSquare;
        
    }
    private void ChangeColorSquare()
    {
        if (index > 3)
        {
            index = 0;
        }
        squareRenderer.material.color = colors[index];

        index++;
    }
    private void OnDisable()
    {
        ColorChanger.OnButtonClicked -= ChangeColorSquare;
    }
    
}
