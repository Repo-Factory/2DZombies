using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTower : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public KeyCode keyCode;
    public GameObject projectile;
    public int ammo = 4;

    void Start()
    {
        firePoint = transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (projectile == null && ammo > 0)
        {
            projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            ammo--;
        }
    }
}
