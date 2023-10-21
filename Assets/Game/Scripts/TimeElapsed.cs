using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeElapsed : MonoBehaviour
{
    public TextMeshProUGUI timeText; // Reference to a UI Text component
    public float elapsedTime = 0;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        float counterTime = 120 - elapsedTime;
        string formattedTime = FormatTime(counterTime);
        timeText.text = "Countdown : " + formattedTime;
    }

    string FormatTime(float seconds)
    {
        int minutes = Mathf.FloorToInt(seconds / 60);
        int remainingSeconds = Mathf.FloorToInt(seconds % 60);
        string formattedTime = string.Format("{0:00}:{1:00}", minutes, remainingSeconds);
        return formattedTime;
    }
}