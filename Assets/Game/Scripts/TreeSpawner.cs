using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameConstants;


public class TreeSpawner : MonoBehaviour
{
    public GameObject basePlant;
    const float interval = (float)FIELD_SPACE / (float)COLUMNS;
    public KeyCode[] keyCodes = { KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R };

    // Start is called before the first frame update
    void Start()
    {
        float currentIndex = FIELD_START +.5f;
        int i = 0;
        while (currentIndex < FIELD_END)
        {
            Instantiate(basePlant, new Vector3(currentIndex, BASELINE, ZERO), Quaternion.identity);
            DefaultTower plant = basePlant.GetComponent<DefaultTower>();
            plant.keyCode = keyCodes[i];
            currentIndex += interval;
            i++;
        }
    }
}
