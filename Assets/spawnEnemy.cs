using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

//싸그리 고쳐라 !!~~~!!~!~! 그냥 오류 덩어리네 ~~~!!~!~!
public class spawnEnemy : MonoBehaviour{
    public static spawnEnemy spawn;
    private int num,
                num2;
   public static float time;
    private int Wtime = 2;
    public GameObject[] Enemies;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > Wtime) {
            SpawnEnemy();
            time = 0;
        }
        
    }

    public void SpawnEnemy()
    {
        num = Random.Range(0, 4);
        num2 = Random.Range(0, 4);
        GameObject topenemy = Instantiate<GameObject>(Enemies[num], new Vector2(16f, 4f), Quaternion.identity);
        GameObject bottomenemy = Instantiate<GameObject>(Enemies[num2], new Vector2(26f, -4f), Quaternion.identity);
    }

   
}
