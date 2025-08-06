using UnityEngine;


public class Projectile : MonoBehaviour
{
    public int Damage = 10;
    public int bulletSpeed = 30;
    private GameObject player;
    private float lifeTime = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            enemyHealth.CurrentHealth -= Damage;
            if (enemyHealth.CurrentHealth <= 0)
            {
                Destroy(other.gameObject);
                playerHealth.Score += enemyHealth.scoreAdd;
            }
            Destroy(gameObject);
        }
    }
}
