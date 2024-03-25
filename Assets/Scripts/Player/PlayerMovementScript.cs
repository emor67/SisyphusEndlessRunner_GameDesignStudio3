using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float movement = horizontalInput * moveSpeed * Time.deltaTime;

        transform.Translate(Vector3.right * movement);
    }
}
