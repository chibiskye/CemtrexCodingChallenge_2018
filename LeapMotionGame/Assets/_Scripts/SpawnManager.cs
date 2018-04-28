using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject[] collectibles;

    public float spawnTime;
    public float delaySpawnTime;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, delaySpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Handles spawning the collectibles
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int collectiblesIndex = Random.Range(0, collectibles.Length);

        Quaternion randRotation = Quaternion.Euler(0f, Random.Range(0, 360), 0f);

        GameObject instance = (GameObject) Instantiate(
            collectibles[collectiblesIndex], spawnPoints[spawnPointIndex].position, randRotation);
    }
}
