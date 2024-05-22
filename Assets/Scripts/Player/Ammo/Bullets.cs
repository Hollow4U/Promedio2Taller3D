using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] protected int damage = 10;
    [SerializeField] protected GameObject enemyW;
    [SerializeField] protected GameObject enemyB;
    public Bullets(int dmg)
    {
        this.damage = dmg;
    }

    public void Start()
    {
        enemyW = GetComponent<EnemyWhite>();
        enemyB = GetComponent<EnemyBlack>();
    }
}
