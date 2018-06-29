using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public GameObject enemy;                 
    public float spawnTime = 10f;             
    public Transform[] spawnPoints;          
    void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
