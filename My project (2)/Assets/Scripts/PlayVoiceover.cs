using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoiceover : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayAudio()
    {
        if(audioSource != null)
        {
            audioSource.Play();
        }
    }
}
