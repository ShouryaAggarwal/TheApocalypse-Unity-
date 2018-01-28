using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCreation : MonoBehaviour {

    public GameObject[] powerUp;
    public float spawnTime = 4f;
    public float spawnDelay = 5f;
    public float xMin, xMax, yMin, yMax;

    // Use this for initialization
    void Start () {
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
        var i = Mathf.FloorToInt(Random.Range(0f, 1.9f));
        Instantiate(powerUp[i], pos, transform.rotation);
    }
}
