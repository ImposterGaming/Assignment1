using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour {

    public float speed = .5f;
    public float DirectionY;
	// Use this for initialization
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
}
