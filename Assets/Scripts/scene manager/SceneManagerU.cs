using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerU : MonoBehaviour
{
    

    public void LoadPoint1()
    {
        SceneManager.LoadScene("1");
    }
    public void LoadPoint2()
    {
        SceneManager.LoadScene("2");
    }
    public void LoadPoint3()
    {
        SceneManager.LoadScene("3");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Manager of all levels");
    }

}
