using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{

    public float MovementSpeed = 0f;
    public float JumpHeight = 0f;
    public float JumpSpeed = 1f;
    public float gravityScale = 1f;

    public CharacterController Controller;
    private Vector3 MoveDir;
    
   
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        MoveDir = new Vector3(Input.GetAxis("Horizontal") * MovementSpeed,0f,Input.GetAxis("Vertical")* MovementSpeed); // makes a new vector3 and addeds the controlers inputs to it.

        if(Input.GetButtonDown("Jump")) // if the jump button is pressed adds the jump amount
        {
            while(MoveDir.y < JumpHeight)
            {
                MoveDir.y = MoveDir.y + JumpSpeed;
            }
                  
        }

        MoveDir.y = MoveDir.y + (Physics.gravity.y * gravityScale) ; //Physics.gravity is the default gravity system unity uses (Can be changed in settings current setting is -9.81 in the Y)
        Controller.Move(MoveDir * Time.deltaTime); //Addes the created vector3 to the player controller to apply the movement
    } 
}
