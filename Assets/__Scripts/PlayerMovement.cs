using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float jumpRate = 10.0f;
    public float gravityRate = -20.0f;
    public float moveSpeed = 10.0f;
    public float laneSpacing = 3;
    private int desiredLane =1;
    private CharacterController controller;
    private Vector3 moveDirection;
    public float loadDelay = 1f;
    public Animator animator;
    public static bool gameOver;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection.z = moveSpeed;
        if (controller.isGrounded){
            UnJump();
            if(SwipeManager.swipeRight){
                desiredLane++;
                if(desiredLane>2)
                    desiredLane = 2;  
            }
            if(SwipeManager.swipeLeft){
                desiredLane--;
                if(desiredLane<0)
                    desiredLane = 0;    
            }

            if(SwipeManager.swipeUp)   
                Jump();

            if(SwipeManager.swipeDown){
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
    } 

    private void FixedUpdate(){
        controller.Move (moveDirection*Time.deltaTime);
    }

    private void Jump(){
        FindObjectOfType<AudioManager>().Play("PlayerJump");
        moveDirection.y = jumpRate;
        animator.SetBool("isJumping",true);
    }

    private void UnJump(){
        animator.SetBool("isJumping",false);
    }

    private void Crouch(){
        controller.height = 1.0f;
        animator.SetBool("isCrouched",true);
    }

    private void UnCrouch(){
        controller.height = 2.0f;
        animator.SetBool("isCrouched",false);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit){
        if(hit.transform.tag == "Obstacle"){
            if(PlayerManager.shielded == false)   
                PlayerManager.gameOver = true;
            else
                UseShield();
        }
    } 
    
    private void RestoreSpeed(){
        moveSpeed = 10f;
        controller.tag = "Player";
        PlayerManager.shielded = false;
    }

    public void UseShield(){
        moveSpeed = 5.0f;
        Invoke("RestoreSpeed",loadDelay/2);
    }
}