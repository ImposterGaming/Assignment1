using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour {

    [SerializeField]
    private float speed = .5f;
    private float DirectionY;

    public GameObject deathEffect;


	void Start () {
        DirectionY = Random.Range(-0.05f, 0.05f);
       
    }
	
	// Update is called once per frame
	void Update () {

        transform.position -= new Vector3(speed, DirectionY, 0f);

        if (transform.position.x <= -80f)
        {
            Destroy(gameObject);
        }


	}
    public void DestroyPlanet()
    {
        Destroy(gameObject);
        GameObject effectIns = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
    }
}
