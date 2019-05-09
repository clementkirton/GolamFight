using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithSeconds : MonoBehaviour
{

    public int DestroyInSeconds = 5;

    private void Start()
    {
        DestroyObjectDelayed();
    }

    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, DestroyInSeconds);
    }
}
