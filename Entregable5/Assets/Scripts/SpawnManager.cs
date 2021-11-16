using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    // Altura maxima y minima de los obstaculos
    private int RandomYRange = 10;
    // Distancia entre obstaculos
    private int obstacleSpacing = 50;
    // Tiempo hasta que aparece el primer obstaculo
    private float InitialSpawnTime = 0.5f;
    // Tiempo entre la aparicion de obstaculos
    private float obstacleTimeSpacing = 5f;

    //Invoca la funcion para spawnear obstaculos

    void Start()
    {
          InvokeRepeating("SpawnObstacle", InitialSpawnTime, obstacleTimeSpacing);
    }
    // Funcion que spawnea obstaculos en Y aleatoria cada 50 metros
    void SpawnObstacle()
    {
        float randomY = Random.Range(-RandomYRange, RandomYRange);
        spawnPos = new Vector3(0, randomY, spawnPos.z + obstacleSpacing);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
