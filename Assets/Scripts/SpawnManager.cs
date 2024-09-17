using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnRangeX = 20.0f;
    public float spawnPosZ = 20.0f;
    public GameObject[] animalPrefabs;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        GameObject randomAnimal = animalPrefabs[animalIndex];
        Instantiate(randomAnimal, spawnPos, randomAnimal.transform.rotation);
    }
}
