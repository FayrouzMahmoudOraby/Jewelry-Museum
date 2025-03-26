using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlaySoundOnGrab : MonoBehaviour
{
    private AudioSource audioSource;
    private XRGrabInteractable grabInteractable; 
    void Start()
    {
        audioSource  = GetComponent<AudioSource>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(PlayGrabSound);
        grabInteractable.selectExited.AddListener(StopGrabSound);
    }

    private void PlayGrabSound(SelectEnterEventArgs args)
    {
        if(audioSource != null)
        {
            audioSource.Play();
        }
    }
    private void StopGrabSound(SelectExitEventArgs args)
    {
        if(audioSource != null)
        {
            audioSource.Stop();
        }
    }
    
}
