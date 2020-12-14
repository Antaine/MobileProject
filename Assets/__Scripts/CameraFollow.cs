using UnityEngine;
/// <summary>
/// Makes Camera Follow Player
/// </summary>
public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    //Transform Camera to Player
    void Start(){
        offset = transform.position - player.transform.position;
    }
    //Update Camera position to follow player
    void LateUpdate(){
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z+player.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition,200*Time.deltaTime);
    }
}
