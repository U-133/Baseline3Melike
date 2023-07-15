using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BossHealth : MonoBehaviour
{
    public int health = 500;
    Animation anim;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }
    public void TakeDamage(int damage)
    {

        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        anim.Play("boss_death");
        Destroy(gameObject);
        //SceneManager.LoadScene("YouWinScene");

    }
}
