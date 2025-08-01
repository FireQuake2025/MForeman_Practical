using UnityEngine;
using UnityEngine.AI;

public class EnemyMovment : MonoBehaviour
{
    [SerializeField] private int damage =10;
    public PlayerHealth playerHealth;
    private NavMeshAgent navMeshAgent;
    public int speed;

    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        playerHealth = other.GetComponent<PlayerHealth>();
        playerHealth.currentHealth -= damage;
        if (playerHealth.currentHealth <= 0)
        {
            Destroy(other.gameObject);
        }
        
    }
}
