using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateRoca : MonoBehaviour
{ 

 public RocaFactory rocaFactory; // Asigna la f�brica de arbustos en el Inspector de Unity.

public float spawnRange = 10f; // Rango m�ximo de la posici�n aleatoria. Puedes ajustar esto en el Inspector de Unity.

public void CreateArbusto()
{
    Vector3 randomPosition = RandomPosition();
    GameObject createdObject = rocaFactory.CreateArbusto();
    createdObject.transform.position = randomPosition;
    // Puedes realizar cualquier otra l�gica aqu�, como rotaci�n o escala del objeto.

}
private Vector3 RandomPosition()
{
    float randomX = Random.Range(-spawnRange, spawnRange);
    float randomY = 0f; // Puedes ajustar la altura si es necesario.
    float randomZ = Random.Range(-spawnRange, spawnRange);
    return new Vector3(randomX, randomY, randomZ);
}

}
