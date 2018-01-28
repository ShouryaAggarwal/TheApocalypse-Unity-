using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPUP : MonoBehaviour {

    private GameObject player;
    private GameObject blast;
    private float flag;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        blast = transform.GetChild(1).gameObject;
        flag = 0;
    }

    // Update is called once per frame
    void Update () {
        if (Vector3.Distance(player.transform.position, transform.position) < 0.35f && flag==0)
        {
            blast.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            var clones = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (var clone in clones)
            {
                if (Vector3.Distance(clone.transform.position, transform.position) < 2f)
                {
                    Destroy(clone);
                    player.GetComponent<GameController>().kills++;
                }
            }
            flag = 1;
        }
        if (blast.transform.localScale.magnitude >= 0.05f*Mathf.Sqrt(3))
            blast.transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);

        if (blast.transform.localScale.magnitude < 0.4f * Mathf.Sqrt(3) && flag == 1)
            Destroy(this.gameObject);
    }
}
