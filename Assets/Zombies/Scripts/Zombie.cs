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
    public int BASELINE = 0;
    public GameOver gameOverScreen;

    void Start()
    {
        gameOverScreen = GameObject.Find("LoseScreen").GetComponent<GameOver>();
    }

    protected void Update()
    {
        Vector3 position = new Vector3((float)transform.position.x, (float)transform.position.y, (float)transform.position.z);                  
        position.z -= (speed * (float)Time.deltaTime);                   
        transform.position = position;
    }
}
