using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    private float leftBound = -15;
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
        if (playerControllerScript.gameOver == false)
        {
           Instantiate(obstaaclePrefab, spawnPos, obstaaclePrefab.transform.rotation);
        }
    
    
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    
    
    }
}

