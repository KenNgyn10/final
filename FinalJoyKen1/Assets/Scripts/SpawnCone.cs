using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCone : MonoBehaviour
{
    public GameObject obstaclePrefab;
   
    private float spawnRangeX = -400;
    private float spawnPosZ = 20;
    private float spawnPosY = 3;
    private float startDelay = 0;
    private float spawnInterval = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
    }
    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, Random.Range(-spawnPosZ, spawnPosZ) );

        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
