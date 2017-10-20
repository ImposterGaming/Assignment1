using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20 2017, Game start UI
public class GameStart : MonoBehaviour {

    public GameObject gameStartUI;
    public GameObject playerStatUI;


	void Start () {
        //time frozen on game start
        Time.timeScale = 0;
	}
    private void Update()
    {
        if (PlayerStats.HasPlayed == 1)
        {
            Time.timeScale = 1;
            playerStatUI.SetActive(true);
            gameStartUI.SetActive(false);
        }
    }

    public void PlayButton() {

        //on button press, hides the ui and causes time to start
        PlayerStats.HasPlayed = 1;
        Time.timeScale = 1;
        playerStatUI.SetActive(true);
        gameStartUI.SetActive(false);

        
    }
}
