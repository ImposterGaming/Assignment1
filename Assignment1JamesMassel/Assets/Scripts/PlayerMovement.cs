using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20m 2017, movement of the player
public class PlayerMovement : MonoBehaviour {

    private float hInput;
    private float vInput;
    private Vector3 curPosition;
    public float speed = 1f;

	void Update () {
        curPosition = transform.position;

        HorizontalMovement();
        VerticalMovement();
        
        StayInBounds();
        transform.position = curPosition;
    }


    public void HorizontalMovement()
    {
        //horizontal movement of player
        hInput = Input.GetAxis("Horizontal");
       
        if (hInput < 0)
        {
            curPosition -= new Vector3(speed, 0f, 0f);
        }
        if (hInput > 0)
        {
            curPosition += new Vector3(speed, 0f, 0f);
        }
    }
    public void VerticalMovement()
    {
        //vertical movement of player
        vInput = Input.GetAxis("Vertical");
        if (vInput < 0)
        {
            curPosition -= new Vector3(0f, speed, 0f);
        }
        if (vInput > 0)
        {
            curPosition += new Vector3(0f, speed, 0f);
        }
    }

    public void StayInBounds()
    {
        //keeps player in bounds
        if (curPosition.x > 45f)
        {
            curPosition.x = 45f;
        }
        if (curPosition.x < -45f)
        {
            curPosition.x = -45f;
        }
        if (curPosition.y > 19f)
        {
            curPosition.y = 19f;
        }
        if (curPosition.y < -19f)
        {
            curPosition.y = -19f;
        }
    }
   
}
