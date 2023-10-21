using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public WinScreen winScreen;
    public LoseScreen loseScreen;
    
    private bool isGameOver = false;
    
    // LOSE
    public int BASELINE = -4;
    
    // WIN
    public const int LEVEL_TIME = 120;
    private float elapsedTime;

    public void Start()
    {
        elapsedTime = 0;
    }

    public void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > LEVEL_TIME)
        {
            winScreen.DisplayWinScreen();
        }

        if (!isGameOver)
        {
            CheckEnemies();
        }
    }

    public void CheckEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            Vector3 enemyPosition = enemy.transform.position;

            if (enemyPosition.y < -4)
            {
                loseScreen.DisplayGameOver((int)elapsedTime);
                break;
            }
        }
    }
}
