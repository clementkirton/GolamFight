using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject Spawn;
    private float CooldownInSeconds = 3f;
    private float timeStamp;


    void Update()
    {
        if (Input.GetButtonDown("SpawnBlock") && timeStamp <= Time.time)
        {
            Instantiate(Spawn, this.transform.position, this.transform.rotation); //This is the posstion and rotation of the object that this script is attatch too.
            timeStamp = Time.time + CooldownInSeconds;
        }
        
    }

}
