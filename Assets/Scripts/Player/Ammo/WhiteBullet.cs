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
        if (other.CompareTag("EnemyWhite"))
        {
            other.GetComponent<EnemyWhite>().life -= damage;
            Destroy(gameObject);
        }
        else if (other.CompareTag("EnemyBlack"))
        {
            Destroy(gameObject);
        }
    }
}
