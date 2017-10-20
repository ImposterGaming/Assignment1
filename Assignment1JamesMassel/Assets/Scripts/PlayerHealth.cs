using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20 2017, Player losing health on collision with enemies, death, updating ui

public class PlayerHealth : MonoBehaviour {

    public Text playerHealth;

    public void Start()
    {
        playerHealth.text = "Lives: " + PlayerStats.Health.ToString();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Planet")
        {
            //collision with enemy
            other.GetComponent<PlanetMovement>().DestroyPlanet();
            LoseHealth();
            UpdateHealthUI();
        }
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            PlayerStats.Points += 10;
            gameObject.GetComponent<AudioSource>().Play();

        }
         
    }

    public void Die()
    {
        Destroy(gameObject);
        //death effect goes here
    }

    public void LoseHealth()
    {
        //player loses health, dies if out of health
        PlayerStats.Health -= 1;
        if (PlayerStats.Health <= 0)
        {
            Die();
        }
    }

    public void UpdateHealthUI()
    {
        //updates the health ui when losing health
        playerHealth.text = "Lives: " + PlayerStats.Health.ToString();
    }
}
