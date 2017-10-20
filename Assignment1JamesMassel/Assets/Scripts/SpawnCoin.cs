using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Assignment1JamesMassel, James Massel, Last Modified by James Massel Oct 20 2017, spawns coins
public class SpawnCoin : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject coin;
    private float timeBetweenTimer;
    public float timeBetweenCoins = 15f;
    private Vector3 randomSpawnPoint;

    // Use this for initialization
    void Start()
    {
        timeBetweenTimer = timeBetweenCoins;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenTimer <= 0)
        {
            //spawns enemies in a random y axis range 
            randomSpawnPoint = new Vector3(spawnPoint.position.x, spawnPoint.position.y + Random.Range(-13f, 13f), spawnPoint.position.z);
            SpawnCoinObject(coin);
            timeBetweenTimer = timeBetweenCoins;
        }
        else
        {
            timeBetweenTimer -= Time.deltaTime;
        }

    }
    public void SpawnCoinObject(GameObject coinPrefab)
    {
        //spawn planet
        Instantiate(coin, randomSpawnPoint, spawnPoint.rotation);
    }
}
