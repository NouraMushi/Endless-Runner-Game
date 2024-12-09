using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (gameObject.transform.position.z < player.transform.position.z - 15)
        {
            Destroy(gameObject);
        }
    }
}
