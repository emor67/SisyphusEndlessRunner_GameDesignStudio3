using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    void Update()
    {
        float movement = moveSpeed * Time.deltaTime;

        transform.Translate(Vector3.back * movement);
    }
}
