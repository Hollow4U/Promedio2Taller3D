using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SpawnEnemy 
{
    [SerializeField] private List<GameObject> enemies;
    public List<GameObject> EnemyPrefabs
    {
        get
        {
            return enemies;
        }
    }
}
