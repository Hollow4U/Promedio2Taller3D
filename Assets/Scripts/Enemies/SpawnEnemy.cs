using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
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
