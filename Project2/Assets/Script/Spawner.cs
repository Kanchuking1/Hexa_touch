using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnRate = 1f;
    public float nextTimeToSpawn = 0f;
    float timeToIncreaseSpawnRate = 1f;

    public GameObject hexagonPrefab;
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad >= nextTimeToSpawn){
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.timeSinceLevelLoad + spawnRate;
        }

        if(Time.time >= timeToIncreaseSpawnRate){
            spawnRate /= 1.002f;
            timeToIncreaseSpawnRate += 1f;
        }
    }
}
