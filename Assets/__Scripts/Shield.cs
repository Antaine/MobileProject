using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Detects Collision of Player and Shield
/// Destroys Shield
/// And Plays Pickup Audio
/// </summary>
public class Shield : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0,20*Time.deltaTime,0);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("PickUpSound");
            Destroy(gameObject);
            PlayerManager.shielded = true;
        }
    }
}