using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameConstants;
public class Spawner : MonoBehaviour
{
    public GameObject chump;
    public GameObject kamikaze;
    public GameObject crawler;
    public GameObject tank;
    
    public enum Enemy
    {
        Chump,
        Kamikaze,
        Crawler,
        Tank
    }

    private Dictionary<Enemy, GameObject> enemyPrefabMap;

    private (Enemy, int)[] spawnProbabilities = 
    {
        (Enemy.Chump, 45),
        (Enemy.Kamikaze, 20),
        (Enemy.Crawler, 25),
        (Enemy.Tank, 10)
    };

    private Enemy[] percentageBar = new Enemy[100];

    public float spawnProbability = 0.0001f;
    public float gameTime = 0f;

    void Start()
    {
        InitializePercentageBar();
        InitializeEnemyPrefabMap();
    }

    void InitializePercentageBar()
    {
        int percentageBarIndex = 0;
        foreach ((Enemy enemyType, int probability) in spawnProbabilities)
        {
            int probabilityTracker = probability;
            while (probabilityTracker > 0)
            {
                percentageBar[percentageBarIndex] = enemyType;
                probabilityTracker--;
                percentageBarIndex++;
            }
        }
    }

    void InitializeEnemyPrefabMap()
    {
        enemyPrefabMap = new Dictionary<Enemy, GameObject>
        {
            { Enemy.Chump, chump},
            { Enemy.Kamikaze, kamikaze },
            { Enemy.Crawler, crawler },
            { Enemy.Tank, tank }
        };
    }

    void Update()
    {
        if (Random.value < spawnProbability)
        {
            spawnEnemy();
        }

        gameTime += Time.deltaTime;

        spawnProbability += GetCurveValue(gameTime);
    }

    void spawnEnemy()
    {
        float xPos = (Random.Range(0, 8) * FIELD_SPACE/COLUMNS) - 4.5f;
        float yPos = ENEMYLINE;
        float zPos = 0;
        Instantiate(enemyPrefabMap[determineEnemy()], new Vector3(xPos, yPos, zPos), Quaternion.identity);
    }

    float GetCurveValue(float t)
    {
        float a = 200000f;  // 2000000
        float b = 60f; 
        return 1f / (1f + (-a * (t - b)));
    }

    Enemy determineEnemy()
    {
        int randomValue = (int) (Random.value * 100);
        return percentageBar[randomValue];
    }
}
