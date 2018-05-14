using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_ : MonoBehaviour {
    public GameObject asdf;
    public static bool IsDead = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DeadPoint();
	}

    private void DeadPoint()
    {
        if (asdf.transform.position.y > 3.72f)
        {
            Debug.Log("잇힝~~~ 듸졋당~~~~~");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            IsDead = true;
        }

        else if (asdf.transform.position.y < -3.81f)
        {
            Debug.Log("잇힝~~~ 듸졋당~~~~~");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            IsDead = true;
        }

        IsDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("잇힝~~~ 듸졋당~~~~~");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
            IsDead = true;
        }

        IsDead = false;
    }
}
