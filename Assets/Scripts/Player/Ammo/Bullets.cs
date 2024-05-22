using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] protected int damage = 10;
  //  [SerializeField] protected EnemyWhite enemyW;
    //[SerializeField] protected EnemyBlack enemyB;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Vector3 direction;
    public Bullets(int dmg)
    {
        this.damage = dmg;
    }

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        rb.velocity = direction * speed;
    }
}
