using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int maxHealth;
    [SerializeField] public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    public void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}

  
