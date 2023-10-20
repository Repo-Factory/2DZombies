using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public const string ENEMY_NAME = "Enemy";
    public const int NO_HEALTH = 0;
    public const int ENEMY_LINE = 16;
    public float damage;
    public float speed;

    void Update()
    {
        Vector3 position = new Vector3((float)transform.position.x, (float)transform.position.y, (float)transform.position.z);
        position.z += (speed * (float)Time.deltaTime);
        transform.position = position;

        if (this.transform.position.z >= ENEMY_LINE)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider collision)
    { 
        if (collision.gameObject.CompareTag(ENEMY_NAME))
        {
            GameObject zombie = collision.gameObject;
            TakeDamage(zombie, damage);
            Destroy(this.gameObject);
        }
    }

    void TakeDamage(GameObject enemy, float damage)
    {
        Zombie zombie = enemy.GetComponent<Zombie>();
        zombie.health -= damage;
        if (zombie.health <= NO_HEALTH)
        {
            Destroy(enemy);
        }
    }
}