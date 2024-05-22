using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern : MonoBehaviour
{
    [SerializeField] private List<GameObject> currentPattern;
    [SerializeField] private List<SpawnEnemy> enemiesPattern;

    [SerializeField] private float timer;
    [SerializeField] private float maxTimer;
    [SerializeField] private int index;

    private void Awake()
    {
        currentPattern = enemiesPattern[Random.Range(0, enemiesPattern.Count)].EnemyPrefabs;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= maxTimer)
        {
            GameObject enemy = Instantiate(currentPattern[index]);
            enemy.transform.position = transform.position;
            index++;
            if(index >= currentPattern.Count)
            {
                index = 0;
            }
            timer = 0;
        }
    }
}
