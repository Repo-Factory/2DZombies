using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinScreen : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void Start()
    {
        gameObject.SetActive(false);
    }

    public void DisplayWinScreen()
    {
        gameObject.SetActive(true);
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}

