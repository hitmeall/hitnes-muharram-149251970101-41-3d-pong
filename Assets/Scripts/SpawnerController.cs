using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public int maxBall = 5; 
    public int spamInterval;
    private List<GameObject> ballList;
    public GameObject ball;

    private float timer = 0;

    void Start()
    {
        ballList = new List<GameObject>();
        SpawnBallRandom();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spamInterval)
        {
            SpawnBallRandom();
            timer -= spamInterval;
        }
    }

    public void SpawnBallRandom()
    {
        SpawnBallPos(Random.Range(1, 5));
    }

    public void SpawnBallPos(int cornerSpawner)
    {
        Vector3 speedSpawned;
        Vector3 spawnPos;
        if (ballList.Count >= maxBall)
        {
            return;
        }
        if (cornerSpawner == 1)
        {
            speedSpawned = new Vector3(36, 0, -36);
            spawnPos = new Vector3(-18, 1, 18);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (cornerSpawner == 2)
        {
            speedSpawned = new Vector3(36, 0, 36);
            spawnPos = new Vector3(-18, 1, -18);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (cornerSpawner == 3)
        {
            speedSpawned = new Vector3(-36, 0, 36);
            spawnPos = new Vector3(13, 1, -13);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (cornerSpawner == 4)
        {
            speedSpawned = new Vector3(-36, 0, -36);
            spawnPos = new Vector3(13, 1, 13);
            SpawnBall(speedSpawned, spawnPos);
        }
    }

    private void SpawnBall(Vector3 spawnedSpeed, Vector3 spawnPos)
    {
        GameObject ballSpawned = Instantiate(ball, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);
        ballSpawned.GetComponent<BallController>().speed = spawnedSpeed;
        ballSpawned.SetActive(true);
        ballList.Add(ballSpawned);
    }

    public void RemoveBall(GameObject ballObject)
    {
        ballList.Remove(ballObject);
        Destroy(ballObject);
    }
    public void RemoveAllBall()
    {
        while (ballList.Count > 0)
        {
            RemoveBall(ballList[0]);
        }
    }
}
