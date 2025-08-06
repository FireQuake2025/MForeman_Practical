using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public event Action<int, int> OnHealthChange;
    public int CurrentHealth;
    public int scoreAdd;
    private PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = maxHealth;
        playerHealth = GetComponent<PlayerHealth>();
        playerHealth = FindAnyObjectByType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth.Score >= 300)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        if (CurrentHealth > 0)
        {
            CurrentHealth = Mathf.Max(CurrentHealth - damageAmount, 0);
            OnHealthChange?.Invoke(CurrentHealth, maxHealth);
        }

    }


}
