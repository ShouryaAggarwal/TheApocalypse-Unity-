using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePUP : MonoBehaviour {

    private GameObject player;
    private GameObject armour;
    private float flag;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        armour = player.transform.GetChild(0).gameObject;
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 0.5f && flag == 0)
        {
            armour.transform.localScale = new Vector3(2f, 3f, 0f);

            Invoke("Normal", 5f);
            transform.localScale = new Vector3(0f, 0f, 0f);
            flag = 1;
        }

    }

    void Normal()
    {
        armour.transform.localScale = new Vector3(0f, 0f, 0f);
        Destroy(this.gameObject);
    }
}

