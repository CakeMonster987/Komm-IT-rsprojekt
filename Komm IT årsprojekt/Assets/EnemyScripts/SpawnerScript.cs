using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float MinSpawnTime;
    [SerializeField] private float MaxSpawnTime;
    private float TimeUntilSpawn;

    void Awake()
    {
        SetTimeUntillSpawn();
    }

    private void Update()
    {
        TimeUntilSpawn -= Time.deltaTime;
        if(TimeUntilSpawn <= 0)
        {
            Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntillSpawn();
        }
    }

    private void SetTimeUntillSpawn()
    {
        TimeUntilSpawn = Random.Range(MinSpawnTime, MaxSpawnTime);
    }
}
