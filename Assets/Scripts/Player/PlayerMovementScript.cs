using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform stoneTransform;
    public Transform handTransform;


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float movement = horizontalInput * moveSpeed * Time.deltaTime*2;

        transform.Translate(Vector3.right * movement);

        transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime*3.2f);
        
        handTransform.position = new Vector3(stoneTransform.position.x + 1.4f, handTransform.position.y, handTransform.position.z);
        
}
}




