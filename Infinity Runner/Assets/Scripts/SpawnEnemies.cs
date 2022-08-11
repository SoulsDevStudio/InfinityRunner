using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    public List<GameObject> EnemiesList = new List<GameObject>();
    public float timeCount;
    public float spawnTimer;

    
    void Update()
    {
        timeCount += Time.deltaTime;
        if(timeCount >= spawnTimer)
        {
            SpawnEnemy();
            timeCount = 0;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(EnemiesList[Random.Range(0, EnemiesList.Count)], transform.position + new Vector3(0, Random.Range(0f,2.5f),0), transform.rotation);
    }
}
