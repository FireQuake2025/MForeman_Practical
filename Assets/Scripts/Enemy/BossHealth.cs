using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public int CurrentHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if(other.tag == "Projectil")
        {
            CurrentHealth -= projectile.Damage;
            if (CurrentHealth <= 0)
            {
                Destroy(gameObject);
                Debug.Log("You Win");
                SceneManager.LoadScene("Level 1");
            }
        }
    }
}
