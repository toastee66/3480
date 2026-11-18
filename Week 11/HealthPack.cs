using System;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int maxHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if (Convert.ToInt32(playerHealth) < 90)
            {
                playerHealth.health += 10;
                Destroy(gameObject);
            }
            
        }
    }
}
