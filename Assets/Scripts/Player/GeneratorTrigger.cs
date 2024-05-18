using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneratorTrigger : MonoBehaviour
{
   // public GameObject objectToInstantiate; // Drag the prefab you want to instantiate into this field in the Inspector
    public Transform generationPosition; // Specify the position where you want to instantiate the object
    public float destroyDelay = 5f;
    public GameObject[] objectsToSpawn;
    public int health = 1;
    public GameObject shield;
    private bool isShieldActive = false;


    void Start()
    {
        if (shield != null)
        {
            shield.SetActive(false); // Baþlangýçta kalkaný gizle
            Debug.Log("Shield set to inactive at start.");
        }
    }

    // This method is called when a Collider enters the trigger
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("GenTrigger"))
        {
            Debug.Log("Level Spawnnnnnnnnnn");
            SpawnRandomObject();
        }
        else if (other.CompareTag("Die"))
        {
            HandleCollisionWithDie();
        }
        else if (other.CompareTag("HealthPotion"))
        {
            //AddHealth(1); // Pot toplandýðýnda 1 can ekle
            ActivateShield();
            Destroy(other.gameObject); // Potu yok et
        }
    }

    void HandleCollisionWithDie()
    {
        if (isShieldActive)
        {
            Debug.Log("Shield absorbed the hit.");
            // Kalkan aktifse çarpýþmayý absorbe eder, oyuncu zarar görmez
        }
        else
        {
            Invoke("RestartScene", 0.5f);
        }
    }
    /*public void AddHealth(int amount)
    {
        health += amount;
        Debug.Log("Health added. Current health: " + health);
    }*/

    public void ActivateShield()
    {
        if (shield != null)
        {
            Debug.Log("Shield activate.");
            shield.SetActive(true); // Kalkaný görünür yap
            isShieldActive = true;
            // Kalkanýn süresini ayarlamak isterseniz
            Invoke("DeactivateShield", 5f); // 5 saniye sonra kalkaný devre dýþý býrak
        }
    }

    private void DeactivateShield()
    {
        if (shield != null)
        {
            Debug.Log("Shield DEactivate.");
            shield.SetActive(false); // Kalkaný gizle
            isShieldActive = false;
        }
    }


    void SpawnRandomObject()
    {
        // Rastgele bir indeks seç
        int randomIndex = Random.Range(0, objectsToSpawn.Length);

        // Seçilen indeksteki objeyi spawn et
        GameObject spawnedObject = Instantiate(objectsToSpawn[randomIndex], generationPosition.position, Quaternion.identity);
        DestroyAfterDelay(spawnedObject, destroyDelay);
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

    public GameObject[] objectsToDestroy; // Array to hold references to the objects to destroy



}
