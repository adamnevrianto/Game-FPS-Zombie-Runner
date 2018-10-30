using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawning : MonoBehaviour {

    [SerializeField]
    private GameObject zombie;
    private GameObject player;
    //GameObject[] monsters;
    float timer = 0;
    float bossSpawn = 0;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if(timer > 10f)
        {
            Instantiate(zombie, transform.position, Quaternion.identity);
            timer = 0;
        }

        
	}
}
