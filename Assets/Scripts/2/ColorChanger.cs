using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorChanger : MonoBehaviour 
{


    public static event Action OnButtonClicked;
    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (OnButtonClicked != null)
            {
                OnButtonClicked();
            }
        }
    }
}