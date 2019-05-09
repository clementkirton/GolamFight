using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    public GameObject Rock;
    private float CooldownInSeconds = 1f;
    private float timeStamp;
    GameObject[] RocksInLevel;

    // Update is called once per frame
    void Update()
    {

        RocksInLevel = GameObject.FindGameObjectsWithTag("Rock");

        int NrOfRocks = RocksInLevel.Length;

        if(NrOfRocks < 50 && timeStamp <= Time.time)
        {
            Vector3 VectorRand = new Vector3(Random.Range(-0.01f, 0.01f), Random.Range(-0.01f, 0.01f), Random.Range(-0.01f, 0.1f));

            GameObject RockSpawn = Instantiate(Rock, transform.position + VectorRand, Quaternion.identity) as GameObject;
            timeStamp = Time.time + CooldownInSeconds;
        }
    }
}
