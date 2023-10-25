using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isMuted = false;

    public void ToggleMute()
    {
        isMuted = !isMuted;
        ToggleAudio(isMuted);
    }

    public void ToggleAudio(bool isMuted)
    {
        if (isMuted)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
    }

    public void OnMouseDown()
    {
        ToggleMute();
    }
}
