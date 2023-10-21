using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public const string ENEMY_NAME = "Enemy";
    public const int NO_HEALTH = 0;
    public const int ENEMY_LINE = 4;
    public float damage;
    public float speed;
    public ResourceCounter resourceCounter;

    public void Start()
    {
        resourceCounter = GameObject.Find("ResourceCounter").GetComponent<ResourceCounter>();
    }

    void Update()
    {
        Vector3 position = new Vector3((float)transform.position.x, (float)transform.position.y, (float)transform.position.z);
        position.y += (speed * (float)Time.deltaTime);
        transform.position = position;

        if (this.transform.position.y >= ENEMY_LINE)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
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
            resourceCounter.addBlood(Random.Range(25, 50));
            resourceCounter.addBone(Random.Range(25, 50));
            Destroy(enemy);
        }
    }
}
