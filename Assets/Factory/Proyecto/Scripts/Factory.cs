using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject CreateObject(GameObject prefab)
    {
        return Instantiate(prefab);
    }
}

