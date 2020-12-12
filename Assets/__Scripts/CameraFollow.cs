using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Variables
    public Transform player;
    private Vector3 offset;

    void Start(){
        offset = transform.position - player.transform.position;
    }

    void LateUpdate(){
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z+player.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition,200*Time.deltaTime);
    }
}
