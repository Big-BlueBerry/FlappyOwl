using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    private int score;
    public Text CountT;

	// Use this for initialization
	void Start () {
        score = 0;
        ShowText();
    }
	
	// Update is called once per frame
	void Update () {
	}

    void ShowText()
    {
        CountT.text = "너님의 점수는!~!~!~" + score.ToString() + "점이야~!!~!~!";
        if (spawnEnemy.time == 2)
            score += 1;
    }
}
