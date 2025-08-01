using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxhealth = 10;
    public int currentHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        currentHealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
