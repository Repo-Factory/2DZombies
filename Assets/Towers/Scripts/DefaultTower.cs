using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTower : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public KeyCode keyCode;
    public GameObject projectile;

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
        if (projectile == null)
        {
            projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
