using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,20*Time.deltaTime,0);
    }

    private void OnTriggerEnter(Collider other){

        if(other.tag == "Player")
        {
            Destroy(gameObject);
            PlayerManager.shielded = true;
        }
    }
}
