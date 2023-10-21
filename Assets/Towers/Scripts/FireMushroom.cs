using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMushroom : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public GameObject projectile;
    public bool isCard = false;
    public const float shootingInterval = 2f;

    void Start()
    {
        firePoint = transform;
        InvokeRepeating("Shoot", 3f, shootingInterval);
    }

    void Update()
    {
        
    }

    public void Shoot()
    {
        if (!isCard)
        {
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
