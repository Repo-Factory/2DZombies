using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public const string ENEMY_NAME = "Enemy";
    public ResourceCounter resourceCounter;

    public void Start()
    {
        resourceCounter = GameObject.Find("ResourceCounter").GetComponent<ResourceCounter>();
    }

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(ENEMY_NAME))
        {
            GameObject zombie = collision.gameObject;
            Destroy(zombie);
            resourceCounter.addBlood(Random.Range(25, 50));
            resourceCounter.addBone(25);
            Destroy(this.gameObject);
        }
    }
}
