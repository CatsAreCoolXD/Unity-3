using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos;
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        spawnPos = obstaclePrefab.transform.position;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void SpawnObstacle()
    {
        if (!playerController.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
