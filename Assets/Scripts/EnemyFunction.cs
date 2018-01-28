using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyFunction : MonoBehaviour {

    private GameObject player;
    public float chaseSpeed;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, chaseSpeed);
        if(Vector3.Distance(player.transform.position,transform.position)<0.3f)
        {
            var clones = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (var clone in clones)
            Destroy(clone);

            var powerUps = GameObject.FindGameObjectsWithTag("PowerUp");
            foreach (var powerUp in powerUps)
                Destroy(powerUp);

            player.GetComponent<GameController>().gameOver.enabled = true;
            Restart();
        }
    }

    void Restart()
    {
        player.GetComponent<GameController>().Re();
    }

}
