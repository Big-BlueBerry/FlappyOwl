using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_ : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y >= -4.11 || transform.position.y <= -4.11)
        {
            Debug.Log("잇힝~~~ 듸졋당~~~~~");
        }

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("잇힝~~~ 듸졋당~~~~~");
        }
    }
}
