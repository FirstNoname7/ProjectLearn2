using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;

    private float startDelay = 2; //������� ������ ������ ����� �������������� ������� 
    private float spawnInterval = 1.5f; //�������� ��� ������ (�� ���� ������ 1.5 ������� ����� �������������� ����� ������)
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
