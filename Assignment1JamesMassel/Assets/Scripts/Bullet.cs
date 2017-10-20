﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private float speed = 1f;

	void Update () {
        transform.Translate(speed, 0f, 0f);
        DestroySelf();
    }

    void OnTriggerEnter(Collider other)
    {
        //if bullet colides with planet, destroy both and add points;
        GetPoints(1);
        Destroy(gameObject);
        other.GetComponent<PlanetMovement>().DestroyPlanet();

    }
    public void GetPoints(int points1)
    {
        //add points 
        PlayerStats.Points += points1;   
    }

    public void DestroySelf()
    {
        //Destroys bullet if it has not hit anything and it leaves screen area
        if (transform.position.x >= 200f)
        {
            Destroy(gameObject);
        }
    }
}
