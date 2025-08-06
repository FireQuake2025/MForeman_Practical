using System;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 10;
    public int CurrentHealth;
    public event Action<int, int> OnHealthChange;
    public GameObject GameFailScreen;
    public int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        CurrentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
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
