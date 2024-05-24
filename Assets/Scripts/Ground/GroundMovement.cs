using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float moveSpeed = 15f; 

    void Update()
    {
        float movement = moveSpeed * Time.deltaTime;

        transform.Translate(Vector3.back * movement);
    }
}
