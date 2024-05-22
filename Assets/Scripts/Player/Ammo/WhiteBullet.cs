using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBullet : Bullets
{
    private WhiteBullet(int dmg) : base(dmg)
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBlack"))
        {
            enemyW.life -= damage;
            Destroy(gameObject);
        }
        else if (other.CompareTag("EnemyWhite"))
        {
            Destroy(gameObject);
        }
    }
}
