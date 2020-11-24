using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  //  public float jumpRate = 5.0f;
 //   public float gravity = 20.0f;
    public float moveSpeed = 5.0f;
    public float laneSpacing = 4;
    private int desiredLane =1;
   // private float moveRate = 2.0f;
    private CharacterController controller;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.z = moveSpeed;


        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if(desiredLane>2)
                desiredLane = 2;  
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                desiredLane--;
                if(desiredLane<0)
                  desiredLane = 0;    
            }

            Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
            if(desiredLane == 0){
                targetPosition += Vector3.left*laneSpacing;
            }
            else if(desiredLane ==2)
            {
                targetPosition += Vector3.right * laneSpacing;
            }

        transform.position = Vector3.Lerp(transform.position,targetPosition,360*Time.deltaTime);
        }
        



    private void FixedUpdate(){
        controller.Move (moveDirection*Time.deltaTime);
    }
}


      /*  if (controller.isGrounded)
        {
            
           /* moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            if(Input.GetAxis("Horizontal")>0)
            {
                moveDirection.x += moveRate;
            }
            else if(Input.GetAxis("Horizontal")<0)
            {
                 moveDirection.x -= moveRate;
            }
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpRate;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection.z = moveSpeed;
        controller.Move(moveDirection * Time.deltaTime);*/