using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float MovementSpeed = 0f;
    public float JumpHeight = 0f;
    public float JumpSpeed = 1f;
    public float gravityScale = 1f;
    public GameObject[] lookAt;

    public float StepSpeed = 360f;
    public CharacterController Controller;
    private Vector3 MoveDir;


    void Start()
    {
        Controller = GetComponent<CharacterController>();
        lookAt = GameObject.FindGameObjectsWithTag("MainCamera");
    }


    void Update()
    {
        
        MoveDir = new Vector3(Input.GetAxis("HorizontalPlayer2") * MovementSpeed, 0f, Input.GetAxis("VerticalPlayer2") * MovementSpeed); // makes a new vector3 and addeds the controlers inputs to it.

        if(Input.GetButtonDown("JumpPlayer2") && Controller.isGrounded) // if the jump button is pressed adds the jump amount
        {
            while (MoveDir.y <= JumpHeight)
            {
                MoveDir.y = MoveDir.y + JumpSpeed;
            }
        }

        MoveDir.y = MoveDir.y + (Physics.gravity.y * gravityScale); //Physics.gravity is the default gravity system unity uses (Can be changed in settings current setting is -9.81 in the Y)
        Controller.Move(MoveDir * Time.deltaTime); //Addes the created vector3 to the player controller to apply the movement

        if (Input.GetButton("TargetPlayer2"))
        {
            Vector3 targetDir = lookAt[0].transform.position - transform.position;
            float step = StepSpeed * Time.deltaTime;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDir);
            MovementSpeed = 5f;

        }
        else
        {
            MovementSpeed = 10f;
        }
    }
}