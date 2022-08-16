using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyPlataform : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject currentEnemy;

    public List<Transform> spawnPoints = new List<Transform>();


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Spawn()
    {
        if(currentEnemy == null)
        {
            CreateEnemy();
        }
    }

    void CreateEnemy()
    {
        int pos = Random.Range(0, spawnPoints.Count);

        GameObject e = Instantiate(enemyPrefab, spawnPoints[pos].position, spawnPoints[pos].rotation);

        currentEnemy = e;
    }
}
