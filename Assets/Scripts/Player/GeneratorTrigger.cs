using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTrigger : MonoBehaviour
{
    public GameObject objectToInstantiate; // Drag the prefab you want to instantiate into this field in the Inspector
    public Transform spawnPosition; // Specify the position where you want to instantiate the object

    // This method is called when a Collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the tag "trigger"
        if (other.CompareTag("GenTrigger"))
        {
            // Instantiate the object at the specified position
            Instantiate(objectToInstantiate, spawnPosition.position, Quaternion.identity);
        }
    }
}
