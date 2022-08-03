using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public List<GameObject> platforms = new List<GameObject>(); // Prefabs Plataforms
    
    public float distance;
    public float offset;

    Transform player;
    Transform currentPlaformPoint;
    int platformIndex;

    List<Transform> currentPlatforms = new List<Transform>(); // Platforms in Game

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i =0; i < platforms.Count; i++)
        {
            Transform p = Instantiate(platforms[i], new Vector2(distance* i,0),transform.rotation).transform;
            currentPlatforms.Add(p);
            offset += distance;
        }

        currentPlaformPoint = currentPlatforms[platformIndex].GetComponent<Platform>().finalPoint;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float distance = player.position.x - currentPlaformPoint.position.x;

        if(distance >= 1)
        {
            Recycle(currentPlatforms[platformIndex].gameObject);
            platformIndex++;

            if(platformIndex > currentPlatforms.Count - 1)
            {
                platformIndex = 0;
            }

            currentPlaformPoint = currentPlatforms[platformIndex].GetComponent<Platform>().finalPoint;
        }
    }

    public void Recycle(GameObject platform)
    {
        platform.transform.position = new Vector2(offset, 0);
        offset += distance;
    }
}
