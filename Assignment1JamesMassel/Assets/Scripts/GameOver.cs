using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20 2017, Game over UI

public class GameOver : MonoBehaviour {

    public Text pointsText;
    public GameObject gameOverUI;
    public GameObject gameStartUI;

    private void Update()
    {
        //sets points on the game over screen
        pointsText.text = "Points: " + PlayerStats.Points.ToString();
    }

    public void Retry()
    {
        //reloads the scene to try again!
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameStartUI.SetActive(false);
        gameOverUI.SetActive(false);
       

    }
}



