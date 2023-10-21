using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameConstants;


public class TreeSpawner : MonoBehaviour
{
    public GameObject basePlant;
    const float interval = (float)FIELD_SPACE / (float)COLUMNS;
    public KeyCode[] keyCodes = new KeyCode[8];

    void Start()
    {
        keyCodes[0] = KeyCode.A; 
        keyCodes[1] = KeyCode.S;
        keyCodes[2] = KeyCode.D;
        keyCodes[3] = KeyCode.F;
        keyCodes[4] = KeyCode.Q;
        keyCodes[5] = KeyCode.W;
        keyCodes[6] = KeyCode.E;
        keyCodes[7] = KeyCode.R;


        float currentIndex = FIELD_START +.5f;
        int i = 0;
        while (currentIndex < FIELD_END)
        {
            basePlant = Instantiate(basePlant, new Vector3(currentIndex, BASELINE, ZERO), Quaternion.identity);
            DefaultTower plant = basePlant.GetComponent<DefaultTower>();
            plant.keyCode = keyCodes[i];
            Debug.Log(basePlant.transform.position);
            Debug.Log(keyCodes[i]);
            currentIndex += interval;
            i++;
        }
    }
}
