using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Vector3 mousePosition, difference;
    public float moveSpeed = 0.05f;
    private float angle;


	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        difference = mousePosition - transform.position;
        angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        if(mousePosition.x<11.5 && mousePosition.x>-11.5 && mousePosition.y<=5 && mousePosition.y>=-5)
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}
