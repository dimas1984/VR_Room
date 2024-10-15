using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Sesuaikan dengan input controller VR
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
    }
}
