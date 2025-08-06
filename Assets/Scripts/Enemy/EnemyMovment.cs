using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyMovment : MonoBehaviour
{
    public int damage = 10;
    private PlayerHealth playerHealth;
    private NavMeshAgent navMeshAgent;
    public int speed;

    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerHealth = GetComponent<PlayerHealth>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            playerHealth = player.GetComponent<PlayerHealth>();
            navMeshAgent.SetDestination(player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            playerHealth = other.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damage);
            if (playerHealth.CurrentHealth <= 0)
            {
                Debug.Log("You Lose");
                SceneManager.LoadScene("Level 1");
            }
            Destroy(gameObject);
        }


    }
}
