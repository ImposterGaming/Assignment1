using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public static int Points;
    public static int Health;
    private int startPoints = 0;
    [SerializeField]
    private int startHealth = 3;
    public Text pointsText;
    
	void Start ()
    {
        Points = startPoints;
        Health = startHealth;
	}

	void Update ()
    {
		if (Health < 0)
        {
            GameOver();
        }

        pointsText.text = "Points: " + Points.ToString();
    }

    public void GameOver()
    {
        
    }
  
}
