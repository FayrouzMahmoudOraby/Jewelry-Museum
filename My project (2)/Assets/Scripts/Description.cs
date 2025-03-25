using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Description : MonoBehaviour
{
    public GameObject infoPanel; // Assign the correct panel in the Inspector

    private void Start()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(false); // Ensure the panel is hidden at the start
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && infoPanel != null) // Ensure the player has the "Player" tag
        {
            infoPanel.SetActive(true); // Show the panel when the player gets close
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && infoPanel != null)
        {
            infoPanel.SetActive(false); // Hide the panel when the player moves away
        }
    }
}
