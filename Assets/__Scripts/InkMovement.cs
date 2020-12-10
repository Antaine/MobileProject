using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InkMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Vector3 moveDirection;

    
    private void FixedUpdate(){
        CharacterController controller = GetComponent<CharacterController>();
        controller.Move (Vector3.back * Time.deltaTime);
        moveDirection = new Vector3(0, 0, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;
        moveDirection.z = moveSpeed;
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        PlayerManager.gameOver = true;
    }


    private void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}