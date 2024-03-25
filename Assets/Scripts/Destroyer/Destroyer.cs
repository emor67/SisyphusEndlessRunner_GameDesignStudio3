using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // This method is called when a Collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Destroy the entering collider's GameObject
        Destroy(other.gameObject);
    }
}
