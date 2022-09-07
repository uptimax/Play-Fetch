using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private int spawnMinInterval = 3;
    private int spawnMaxInterval = 6; // setting the max spawn interval should return 5 as max

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        Debug.Log(spawnInterval);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        var ball = ballPrefabs[Random.Range(0, ballPrefabs.Length)];
        // instantiate ball at random spawn location
        Instantiate(ball, spawnPos, ball.transform.rotation);
        spawnInterval = Random.Range(spawnMinInterval, spawnMaxInterval);
    }

}
