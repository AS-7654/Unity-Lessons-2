using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;

    private float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Press “S” to spawn an animal
        if (Input.GetKeyDown(KeyCode.S))
        {
            // 1️⃣ Pick a random X across the allowed spawn range
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);

            // 2️⃣ Z just inside the DestroyOutOfBounds ceiling (topBound = 30)
            //    Padding of 0.5 keeps us safely below the kill-zone
            float safeZ = 29.5f;   // 30f - 0.5f

            // 3️⃣ Build the final spawn position
            Vector3 spawnPos = new Vector3(randomX, 0f, safeZ);

            // 4️⃣ Choose a random prefab from the array
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            // 5️⃣ Optional tilt: 20° around the Z-axis
            Quaternion spawnRot = Quaternion.Euler(0f, 0f, 20f);

            // 6️⃣ Pop the critter into the world
            Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRot);
        }
    }
}
