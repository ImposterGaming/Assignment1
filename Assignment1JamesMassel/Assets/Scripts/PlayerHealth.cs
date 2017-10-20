using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public Text playerHealth;

    public void Start()
    {
        playerHealth.text = "Lives: " + PlayerStats.Health.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        //collision with enemy
        other.GetComponent<PlanetMovement>().DestroyPlanet();
        LoseHealth();
        UpdateHealthUI();
    }

    public void Die()
    {
        Destroy(gameObject);
        //death effect goes here
    }

    public void LoseHealth()
    {
        PlayerStats.Health -= 1;
        if (PlayerStats.Health <= 0)
        {
            Die();
        }
    }

    public void UpdateHealthUI()
    {
        playerHealth.text = "Lives: " + PlayerStats.Health.ToString();
    }
}
