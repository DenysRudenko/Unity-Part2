﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;


    private float firstInterval = 3.0f;
    private float secondInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int randomBall = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(firstInterval, secondInterval));
    }

}
