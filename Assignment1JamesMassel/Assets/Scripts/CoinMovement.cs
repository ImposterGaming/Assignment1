using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20 2017, makes the coins move towards player
public class CoinMovement : MonoBehaviour {


    [SerializeField]
    private float speed = .5f;
    private Vector3 coinRotation;
    
    void Start()
    {
        coinRotation = new Vector3(90f,0f,0f);
    }

    void Update()
    {
        //moves coin left
        transform.position -= new Vector3(speed, 0f, 0f);
        Rotate();

        if (transform.position.x <= -80f)
        {
            Destroy(gameObject);
        }

        

    }


    public void Rotate()
    {
        //rotates coin
        transform.Rotate(coinRotation * Time.deltaTime);
    }
}
