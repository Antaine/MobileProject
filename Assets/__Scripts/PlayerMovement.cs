using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15.0f;
    public float jumpRate = 5.0f;
    public float gravity = 20.0f;
    private float moveSpeed = 5.0f;

    private Vector3 moveDirection = Vector3.back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            controller.Move (Vector3.back * Time.deltaTime);
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpRate;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection.z = moveSpeed;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
