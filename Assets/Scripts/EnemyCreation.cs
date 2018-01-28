using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreation : MonoBehaviour {

    public GameObject enemy;
    private GameObject player;
    public float spawnTime = 1f;
    public float spawnDelay = 5f;
    public float xMin, xMax, yMin, yMax;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
        xMin = -11.5f;
        xMax = 11.5f;
        yMin = -5f;
        yMax = 5f;
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
        Instantiate(enemy, pos, transform.rotation);
        player.GetComponent<GameController>().time++;
    }
}
