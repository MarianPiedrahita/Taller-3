using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class factory : MonoBehaviour
{

    [SerializeField] GameObject prefab;

    public GameObject SpawnearObjeto()
    {
        GameObject gameObject = Instantiate(prefab);
        return gameObject;
    }


}
