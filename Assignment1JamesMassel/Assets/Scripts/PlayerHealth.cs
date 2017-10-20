using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    private int health;
    public int startHealth = 3;
    public Text playerHealth;


	void Start () {
        health = startHealth;
	}
	
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        LoseHealth();
        UpdateHealthUI();
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        //game over code
    }

    public void LoseHealth()
    {
        health -= 1;
    }

    public void UpdateHealthUI()
    {
        playerHealth.text = health.ToString();
    }
}
