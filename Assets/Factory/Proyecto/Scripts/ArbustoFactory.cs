using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbustoFactory : Factory
{
    public GameObject arbustoPrefab; // Asigna el prefab del arbusto en el Inspector de Unity.

    public GameObject CreateArbusto()
    {
        return CreateObject(arbustoPrefab);
    }
}

