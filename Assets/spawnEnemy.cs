using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.UI;

public class spawnEnemy : MonoBehaviour{
    public static spawnEnemy spawn;
    private int num,
                num2;
    private static float time;
    private int Wtime = 2;
    public GameObject[] Enemies;
    private int score;
    public Text CountT;

    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > Wtime)
        {
            score += 1;
            SpawnEnemy();
            time = 0;
        }
        ShowText();
    }

    public void SpawnEnemy()
    {
        num = Random.Range(0, 4);
        num2 = Random.Range(0, 4);
        GameObject topenemy = Instantiate<GameObject>(Enemies[num], new Vector2(16f, 4f), Quaternion.identity);
        GameObject bottomenemy = Instantiate<GameObject>(Enemies[num2], new Vector2(26f, -4f), Quaternion.identity);
    }

    void ShowText()
    {
        CountT.text = "너님의 점수는!~!~!~" + score.ToString() + "점이야~!!~!~!";
        if (GameOver_.IsDead == true)
            score = 0;
    }
}
