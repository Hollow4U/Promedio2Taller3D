using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [Header("Life Variables")]
    [SerializeField] private int life;

    private void Update()
    {
        LoseCondition();
    }

    private void LoseCondition()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("EnemyWhite"))
        {
            life--;
        }
        else if(collision.gameObject.CompareTag("EnemyBlack"))
        {
            life--;
        }
    }
}
