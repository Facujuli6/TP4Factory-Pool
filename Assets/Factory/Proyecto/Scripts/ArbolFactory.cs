using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolFactory : Factory
{
    public GameObject arbolPrefab; // Asigna el prefab del arbusto en el Inspector de Unity.

    public GameObject CreateArbusto()
    {
        return CreateObject(arbolPrefab);
    }
}

