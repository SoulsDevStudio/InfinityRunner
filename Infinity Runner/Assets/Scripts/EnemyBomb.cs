using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomb : Enemy
{
    public GameObject bomb;
    public Transform pointFire;

    float throwTimer;
    public float throwCount;


    void Start()
    {
        
    }

    void Update()
    {
        throwTimer += Time.deltaTime;
        
        if(throwTimer >= throwCount)
        {
            Instantiate(bomb, pointFire.position, pointFire.rotation);
            throwTimer = 0;
        }
    }
}
