using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Handles Ink Wave Movement and Player Collision to trigger Game Over
/// </summary>
public class InkMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Vector3 moveDirection;
    
    //Moves Wave of Ink on Map
    private void FixedUpdate(){
        CharacterController controller = GetComponent<CharacterController>();
        controller.Move (Vector3.back * Time.deltaTime);
        moveDirection = new Vector3(0, 0, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;
        moveDirection.z = moveSpeed;
        controller.Move(moveDirection * Time.deltaTime);
    }

    //Collision Detection for Ink
    private void OnTriggerEnter(Collider other){
        PlayerManager.gameOver = true;
    }
}