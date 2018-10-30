using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints; // the parent of the spawn points
    public GameObject landingAreaPrefab;

    private bool reSpawn = false;
    private Transform[] spawnPoints;
    public bool lastRespawnToggle = false;
    

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        reSpawn = true;
        
	}
	
	// Update is called once per frame
	void Update () {
		if(lastRespawnToggle != reSpawn)
        {
            ReSpawn();
            reSpawn = false;
        }
        else
        {
            lastRespawnToggle = reSpawn;
        }
	}

    private void ReSpawn() {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }

    void OnFindClearArea()
    {
        Invoke("DropFlare", 5f);
        BroadcastMessage("OnClearArea");
    }

    void DropFlare()
    {
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
    }
}
