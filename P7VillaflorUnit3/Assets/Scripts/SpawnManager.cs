using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver )
        {
           int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);

            Instantiate(
                obstaclePrefabs[obstacleIndex],
                spawnPos,
                obstaclePrefabs[obstacleIndex].transform.rotation);
                
            }
        }
    }