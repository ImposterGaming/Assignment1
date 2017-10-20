using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public GameObject firePoint;
    private float shootTimer = 0f;
    public float shootRate = .5f;

	void Update () {
        Fire();
	}
    public void Fire()
    {
        //space pressed
        float fired = Input.GetAxis("Fire1");
        if (fired > 0)
        {
            if (shootTimer <= 0f)
            {
                if (bullet != null)
                {
                    Instantiate(bullet, firePoint.transform.position, transform.rotation);
                }
                Debug.Log("fired");
                shootTimer = shootRate;
            } 
        }
        shootTimer -= Time.deltaTime;
    }
}
