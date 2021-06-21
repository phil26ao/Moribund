using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform[] spawnPoints;

    public float startSpawnTime = 1f;
    private float spawnTime;

    void Start()
    {

        spawnTime = startSpawnTime;

    }

    void Update()
    {
        if (spawnTime <= 0)
        {
            int randEnemy = Random.Range(0, enemyPrefab.Length);
            int randSpawnPts = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefab[randEnemy], spawnPoints[randSpawnPts].position, transform.rotation);

            spawnTime = startSpawnTime;
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
