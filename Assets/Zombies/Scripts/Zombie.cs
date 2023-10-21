using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie : MonoBehaviour
{
    public string type;
    public float health;
    public float damage;
    public float speed;

    protected void Update()
    {
        Vector3 position = new Vector3((float)transform.position.x, (float)transform.position.y, (float)transform.position.z);                  
        position.y -= (speed * (float)Time.deltaTime);                   
        transform.position = position;
    }
}
