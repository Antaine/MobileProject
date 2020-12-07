using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InkMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Vector3 moveDirection;
    [SerializeField] float loadDelay = 2.0f;
    public GameObject gameMenuUI;
    public GameObject gameOverMenuUI;
    
    void Start()
    {
        //CharacterController controller = GetComponent<CharacterController>();
    }

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
        print("Trigger from collision");
        DeathScreen();
       // Invoke("ReloadScene",loadDelay);
    }

    void DeathScreen(){
        gameOverMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;
    }
    private void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}