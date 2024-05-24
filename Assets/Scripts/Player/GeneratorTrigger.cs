using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneratorTrigger : MonoBehaviour
{
   // public GameObject objectToInstantiate; // Drag the prefab you want to instantiate into this field in the Inspector
    public Transform generationPosition; // Specify the position where you want to instantiate the object
    public float destroyDelay = 6f;
    public GameObject[] objectsToSpawn;
    public GameObject[] objectsToDestroy; // Array to hold references to the objects to destroy
    //public int health = 1;
    public GameObject shield;
    private float shieldDuration = 0f;
    private bool isShieldActive = false;
    //shield scale
    public float animationSpeed = 0.5f; // Speed of the scaling animation

    private Vector3 initialScale; // Initial scale of the object
    private float targetScale; // Target scale for the animation


    void Start()
    {
        if (shield != null)
        {
            shield.SetActive(false); // Ba�lang��ta kalkan� gizle
            Debug.Log("Shield set to inactive at start.");
        }

        // Store the initial scale of the target GameObject
        initialScale = shield.transform.localScale;
        // Calculate the target scale for the animation
        targetScale = initialScale.magnitude + initialScale.magnitude * 0.1f;
    }

    void Update()
    {
        // Calculate the scaling factor using sine function
        float scaleFactor = Mathf.PingPong(Time.time * animationSpeed, targetScale - initialScale.magnitude);
        
        // Apply scaling to the target GameObject
        shield.transform.localScale = initialScale + Vector3.one * scaleFactor;
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
            //AddHealth(1); // Pot topland���nda 1 can ekle
            ActivateShield();
            Destroy(other.gameObject); // Potu yok et
        }
    }

    void HandleCollisionWithDie()
    {
        if (isShieldActive)
        {
            Debug.Log("Shield absorbed the hit.");
            // Kalkan aktifse �arp��may� absorbe eder, oyuncu zarar g�rmez
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
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
            shield.SetActive(true); // Kalkan� g�r�n�r yap
            isShieldActive = true;
            // Kalkan�n s�resini ayarlamak isterseniz
            shieldDuration += 5f;
            Invoke("DeactivateShield", shieldDuration); // 5 saniye sonra kalkan� devre d��� b�rak
            shieldDuration = 0;
        }
    }

    private void DeactivateShield()
    {
        if (shield != null)
        {
            Debug.Log("Shield DEactivate.");
            shield.SetActive(false); // Kalkan� gizle
            isShieldActive = false;
        }
    }


    void SpawnRandomObject()
    {
        // Rastgele bir indeks se�
        int randomIndex = Random.Range(0, objectsToSpawn.Length);

        // Se�ilen indeksteki objeyi spawn et
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

    



}
