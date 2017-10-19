using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject enemy;

    public float timeBetweenEnemies = 5f;
    private Vector3 randomSpawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (timeBetweenEnemies <= 0)
        {
            randomSpawnPoint = new Vector3(spawnPoint.position.x, spawnPoint.position.y + Random.Range(-13f, 13f), spawnPoint.position.z);
            SpawnPlanet(enemy);
            timeBetweenEnemies = 5f;
        }
        else
        {
            timeBetweenEnemies -= Time.deltaTime;
        }
       


	}
    public void SpawnPlanet(GameObject enemyPrefab)
    {
        Instantiate(enemyPrefab, randomSpawnPoint, spawnPoint.rotation);
    }
}
