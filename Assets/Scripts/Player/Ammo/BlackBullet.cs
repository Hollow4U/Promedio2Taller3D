using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBullet : Bullets
{
    private BlackBullet (int dmg) : base (dmg)
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EnemyBlack"))
        {
            other.GetComponent<EnemyBlack>().life -= damage;
            Destroy(gameObject);
        }
        else if(other.CompareTag("EnemyWhite"))
        {
            Destroy(gameObject);
        }
    }
}
