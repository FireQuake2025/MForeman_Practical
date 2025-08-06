using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform[] SpawnLocation;
    public GameObject[] Enemy;
    public GameObject Boss;
    public int waveNumber;
    private int spawnNumberMin = 1;
    private int spawnNumberMax = 4;
    private float spawnTimeMin = 3;
    private float spawnTimeMax = 5;
    private PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        playerHealth = FindAnyObjectByType<PlayerHealth>();
        StartWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartWave()
    {
        int randomNumberToSpawn = Random.Range(spawnNumberMin, spawnNumberMax);
        for (int i = 0; i < randomNumberToSpawn; i++)
        {
            SpawnEnemy();
        }
        for (int i = 0; i < waveNumber; i++)
        {
            Invoke("StartWave", Random.Range(spawnTimeMin, spawnTimeMax));
        }
        
    }


    private void SpawnEnemy()
    {
        int randomNumberLocation = Random.Range(0, 3);
        int randomNumberEnemyType = Random.Range(0, 2);
        Instantiate(Enemy[randomNumberEnemyType], SpawnLocation[randomNumberLocation].position, SpawnLocation[randomNumberLocation].rotation);
        if(playerHealth.Score == 300)
        {
            Boss.SetActive(true);
        }
    }
}
