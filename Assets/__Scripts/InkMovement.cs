using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lnkMovement : MonoBehaviour
{
    public float moveRate = 10.0f;
    private Vector3 moveDirection;

    void Update()
    {
         moveDirection.z = moveRate;
    }
}
