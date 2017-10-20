using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20m 2017, Scrolls the star particle effects to show movement.

public class BackgroundScroll : MonoBehaviour {

	

	void Update () {
        //scrolls the stars to show movement. uses 2 sets of stars and once one is out of view it moves it to another position to be used again
        transform.Translate(-0.25f, 0, 0);
     
        if (transform.position.x <=-540f)
        {
            transform.position = new Vector3(540, 0f,100f);
        }
	}
}
