using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameConstants;


public class TreeSpawner : MonoBehaviour
{
    public GameObject basePlant;
    const float interval = (float)FIELD_SPACE / (float)COLUMNS;

    // Start is called before the first frame update
    void Start()
    {
        float currentIndex = FIELD_START +.5f;
        while (currentIndex < FIELD_END)
        {
            Instantiate(basePlant, new Vector3(currentIndex, BASELINE, ZERO), Quaternion.identity);
            currentIndex += interval;
        }
    }
}
