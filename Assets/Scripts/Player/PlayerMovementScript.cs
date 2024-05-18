using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform stoneTransform;
    public Transform rightHandTransform;
    public Transform leftHandTransform;


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float movement = horizontalInput * moveSpeed * Time.deltaTime*2;

        transform.Translate(Vector3.right * movement);

        transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
        
        rightHandTransform.position = new Vector3(stoneTransform.position.x + 0.7f, rightHandTransform.position.y, rightHandTransform.position.z);
        leftHandTransform.position = new Vector3(stoneTransform.position.x - 0.7f, leftHandTransform.position.y, leftHandTransform.position.z);
    }
}




