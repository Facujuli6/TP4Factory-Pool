using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaFactory : Factory
{
    public GameObject rocaPrefab; // Asigna el prefab del arbusto en el Inspector de Unity.

    public GameObject CreateArbusto()
    {
        return CreateObject(rocaPrefab);
    }
}

