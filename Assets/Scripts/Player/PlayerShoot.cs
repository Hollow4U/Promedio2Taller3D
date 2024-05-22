using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefabW;
    [SerializeField] private GameObject bulletPrefabB;
    [SerializeField] private Transform shootingPoint;

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bulletW = Instantiate(bulletPrefabW);
            bulletW.transform.position = shootingPoint.position;
            bulletW.GetComponent<WhiteBullet>().SetDirection(transform.forward);

        }
        else if(Input.GetMouseButtonDown(1))
        {
            GameObject bulletB = Instantiate(bulletPrefabB);
            bulletB.transform.position = shootingPoint.position;
            bulletB.GetComponent<BlackBullet>().SetDirection(transform.forward);
        }
    }
}
