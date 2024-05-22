using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int life = 20;

    public Enemy (int life)
    {
        this.life = life;
    }

    private void Update()
    {
        ChangeLife();
    }

    private void ChangeLife()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
