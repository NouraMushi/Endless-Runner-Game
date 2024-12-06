using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject[] obstaclePrefabs;
    private Vector3 obstacleSpawner;

    void Update()
    {
        float distanceToHorizon = Vector3.Distance(player.gameObject.transform.position, obstacleSpawner);

        if (distanceToHorizon < 120)
        {
            SpawnerObstacles();
        }
    }

    void SpawnerObstacles()
    {
        obstacleSpawner = new Vector3(0, 0.4f, obstacleSpawner.z + 5);
        Instantiate(obstaclePrefabs[(Random.Range(0, obstaclePrefabs.Length))], obstacleSpawner, Quaternion.identity);
    }
}
