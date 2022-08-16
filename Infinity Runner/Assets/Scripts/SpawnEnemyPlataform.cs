using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyPlataform : MonoBehaviour
{
    public GameObject enemyPrefab;

    public List<Transform> spawnPoints = new List<Transform>();


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void CreateEnemy()
    {
        int pos = Random.Range(0, spawnPoints.Count);

        GameObject e = Instantiate(enemyPrefab, spawnPoints[pos].position, spawnPoints[pos].rotation);
    }
}
