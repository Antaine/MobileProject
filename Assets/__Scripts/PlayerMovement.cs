using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpRate = 10.0f;
    public float gravityRate = -20.0f;
    public float moveSpeed = 5.0f;
    public float laneSpacing = 4;
    private int desiredLane =1;
   // private float moveRate = 2.0f;
    private CharacterController controller;
    private Vector3 moveDirection;
    public float loadDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.z = moveSpeed;
        if (controller.isGrounded){
            if(SwipeManager.swipeRight)
            {
                desiredLane++;
                if(desiredLane>2)
                    desiredLane = 2;  
                }
            if(SwipeManager.swipeLeft)
            {
                desiredLane--;
                if(desiredLane<0)
                    desiredLane = 0;    
            }

            if(SwipeManager.swipeUp)
            {
                Jump();
            }

            if(SwipeManager.swipeDown)
            {
                Crouch();
                Invoke("UnCrouch",loadDelay);
            }
        }
        else{ moveDirection.y += gravityRate*Time.deltaTime;}
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if(desiredLane == 0)
        targetPosition += Vector3.left*laneSpacing;
        else if(desiredLane ==2)
            targetPosition += Vector3.right * laneSpacing;

        if(transform.position == targetPosition)
            return;
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
        if(moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);
       // transform.position = Vector3.Lerp(transform.position,targetPosition,360*Time.deltaTime);
        //controller.center = controller.center;
        
    } 



    private void FixedUpdate(){
        controller.Move (moveDirection*Time.deltaTime);
    }

    private void Jump(){
        moveDirection.y = jumpRate;
    }

    private void Crouch(){
        Debug.Log("Crouch worked");
        controller.height = 1.0f;
    }

    private void UnCrouch(){
        Debug.Log("UnCrouch worked");
        controller.height = 2.0f;
    }
}