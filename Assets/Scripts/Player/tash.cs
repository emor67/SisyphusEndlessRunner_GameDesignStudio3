using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tash : MonoBehaviour
{
    public float moveSpeed = 7.5f;

    void Update()
    {
        float movement = moveSpeed * Time.deltaTime;

        transform.Translate(Vector3.back * movement);
    }
}