using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20 2017, Controls and resets the health and points. if out of lives calls game over ui
public class PlayerStats : MonoBehaviour {

    public static int Points;
    public static int Health;
    private int startPoints = 0;
    [SerializeField]
    private int startHealth = 3;
    public Text pointsText;
    public GameObject gameOverUI;
    public static int HasPlayed = 0;
    public Text healthText;
    public GameObject statUI;
	void Start ()
    {
        Points = startPoints;
        Health = startHealth;
        healthText.text = "Lives: "+ startHealth.ToString();
        
	}

	void Update ()
    {
		if (Health <= 0)
        {
            GameOver();
        }

        pointsText.text = "Points: " + Points.ToString();
    }

    public void GameOver()
    {
        //if out of lives, pull up game over UI
        statUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
  
}
