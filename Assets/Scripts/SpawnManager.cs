using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;

    private float startDelay = 2; //сколько секунд спустя будут генерироваться объекты 
    private float spawnInterval = 1.5f; //интервал для спауна (то есть каждые 1.5 секунды будет генерироваться новый объект)
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int x = Random.Range(-20, 20);
        Instantiate(animalPrefabs[animalIndex], new Vector3(x, 0, 20), new Quaternion(0,90,0,0));
    }
}
