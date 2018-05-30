using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSPawnPoints; //the parent of the spawn points
    public bool respawn;
    private Transform[] spawnPoint;
    private bool lastToggle = false;
	void Start () {
        spawnPoint =playerSPawnPoints.GetComponentsInChildren<Transform>();
        print(spawnPoint.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if(lastToggle != respawn)
        {
            Respawn();
            respawn = false;
        }else
        {
            lastToggle = respawn;
        }
	}
    private void Respawn()
    {
        int i = Random.Range(1, spawnPoint.Length);
        transform.position = spawnPoint[i].transform.position;
    }
}
