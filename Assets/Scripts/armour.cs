using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armour : MonoBehaviour {

    private GameObject player;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update () {
        var clones = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var clone in clones)
        {
            if (Vector3.Distance(clone.transform.position, player.transform.position) < transform.localScale.magnitude / 5.5)
            {
                Destroy(clone);
                player.GetComponent<GameController>().kills++;
            }
        }
    }
}
