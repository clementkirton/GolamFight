using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer2 : MonoBehaviour
{
    public GameObject Shoot;
    private float CooldownInSeconds = 2f;
    private float timeStamp;
    public float Speed = 5000;
    public Animator anim;
    public GameObject MainBody;
    int AttkHash = Animator.StringToHash("Attk");
    // public GameObject SpawnPoint;

    private void Start()
    {
       // MainBody = GetComponentInChildren<GameObject>();
        anim = MainBody.GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Player2Shoot") && timeStamp <= Time.time)
        {
            anim.SetBool(AttkHash, true);
            GameObject bullet = Instantiate(Shoot, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * Speed);
            timeStamp = Time.time + CooldownInSeconds;
        }

        if (Input.GetButtonUp("Player2Shoot"))
        {
            anim.SetBool(AttkHash, false);
        }
    }
}
