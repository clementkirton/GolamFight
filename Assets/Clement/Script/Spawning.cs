using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawning : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    //public GameObject Player3;
    // public GameObject Player4;
    public static bool Player1Spawn = false;
    public static bool Player2Spawn =   false;
    public int LastSpawn = 0;

    GameObject[] Spawns;



    void Start()
    {
        Spawns = GameObject.FindGameObjectsWithTag("SpawnPoint");
        SpawnPlayer(1);
        SpawnPlayer(2);
               


    }
    private void Update()
    {
        if(Player1Spawn == true)
        {
            SpawnPlayer(1);
            Player1Spawn = false;
        }
        if (Player2Spawn == true)
        {
            SpawnPlayer(2);
            Player2Spawn = false;
        }
    }

    public void SpawnPlayer(int Playernr)
    {
        switch (Playernr)
        {
            case 1:
                {
                    int RandomSpawn = 0;
                    RandomSpawn = Random.Range(0, Spawns.Length);

                    while(RandomSpawn == LastSpawn)
                    {
                        RandomSpawn = Random.Range(0, Spawns.Length);
                    }
                    GameObject SpawnPoint = Spawns[RandomSpawn];
                    Instantiate(Player1, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
                    LastSpawn = RandomSpawn;
                }
                break;
            case 2:
                {
                    int RandomSpawn = 0;
                    RandomSpawn = Random.Range(0, Spawns.Length);

                    while (RandomSpawn == LastSpawn)
                    {
                        RandomSpawn = Random.Range(0, Spawns.Length);
                    }
                    GameObject SpawnPoint = Spawns[RandomSpawn];
                    Instantiate(Player2, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
                    LastSpawn = RandomSpawn;
                }
                break;

        }
    }
}
    

