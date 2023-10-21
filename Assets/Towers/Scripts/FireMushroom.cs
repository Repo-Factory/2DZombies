using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMushroom : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public bool isCard = false;
    public const float shootingInterval = 1f;
    
    public void Start()
    {
        firePoint = transform;
        InvokeRepeating("Shoot", 2f, shootingInterval);
    }

    public void Shoot()
    {
        if (!isCard)
        {
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
