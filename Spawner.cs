using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstaclePatterns;
    private float timeBTWspawn;
    public float startSpawn;

    private void Update()
    {
        if (timeBTWspawn < 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBTWspawn = startSpawn;
        }
        else
        {
            timeBTWspawn -= Time.deltaTime;
        }
    }
}
