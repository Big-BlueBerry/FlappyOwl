using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x - 0.2f, transform.position.y);

        if (transform.position.x <= -14.73f)
            transform.position = new Vector2(14.82f, transform.position.y);
    }
}
