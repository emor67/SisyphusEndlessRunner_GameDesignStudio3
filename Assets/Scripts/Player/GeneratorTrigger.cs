using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneratorTrigger : MonoBehaviour
{
    public GameObject objectToInstantiate; // Drag the prefab you want to instantiate into this field in the Inspector
    public Transform generationPosition; // Specify the position where you want to instantiate the object
    public float destroyDelay = 5f;

    // This method is called when a Collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the tag "trigger"
        if (other.CompareTag("GenTrigger"))
        {
            // Instantiate the object at the specified position
            GameObject instantiatedObject = Instantiate(objectToInstantiate, generationPosition.position, Quaternion.identity);
            DestroyRandomObjects(objectsToDestroy, 4);

            // Destroy the instantiated object after the specified delay
            DestroyAfterDelay(instantiatedObject, destroyDelay);
        }
        else if (other.CompareTag("Die"))
        {
            Invoke("RestartScene", 0.5f);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Method to destroy the object after a delay
    void DestroyAfterDelay(GameObject obj, float delay)
    {
        // Check if the object is null
        if (obj == null)
        {
            Debug.LogWarning("Object to destroy is null.");
            return;
        }

        // Destroy the object after the specified delay
        Destroy(obj, delay);
    }
    ////////////
   public GameObject[] objectsToDestroy; // Array to hold references to the objects to destroy

    void Start()
    {
        // Randomly select and destroy 4 objects
        
    }

    void DestroyRandomObjects(GameObject[] objects, int count)
    {
        // Make sure there are enough objects to destroy
        if (objects.Length < count)
        {
            Debug.LogWarning("Trying to destroy more objects than available.");
            return;
        }

        // Shuffle the array of objects
        Shuffle(objects);

        // Destroy the specified number of objects
        for (int i = 0; i < count; i++)
        {
            Destroy(objects[i]);
        }
    }

    // Fisher-Yates shuffle algorithm to shuffle the array
    void Shuffle(GameObject[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            GameObject temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }
}
