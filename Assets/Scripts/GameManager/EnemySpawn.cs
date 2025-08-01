using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform[] SpawnLocation;
    public GameObject Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Enemy, SpawnLocation[0].position, SpawnLocation[0].rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
