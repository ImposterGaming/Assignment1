using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20 2017, rotates planets in a random rotaion
public class RandomRotation : MonoBehaviour {

    private Vector3 planetRotation;
    void Start()
    {
        planetRotation = new Vector3(Random.Range(-90f, 90f), Random.Range(-90f, 90f), Random.Range(-90f, 90f));
    }

    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(planetRotation * Time.deltaTime);
    }
}
