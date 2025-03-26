using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class JewelryLightToggle : MonoBehaviour
{
    private Light currentLight;
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        // Ensure all lights in the scene are OFF at the start
        Light[] allLights = FindObjectsOfType<Light>();
        foreach (Light light in allLights)
        {
            light.enabled = false;
        }

        grabInteractable = GetComponent<XRGrabInteractable>();

        // Listen for grab and release events
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (currentLight != null)
        {
            currentLight.enabled = true; // Turn light ON when grabbing
        }
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        if (currentLight != null)
        {
            currentLight.enabled = false; // Turn light OFF when releasing
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jewelry"))
        {
            currentLight = other.GetComponentInChildren<Light>();

            if (currentLight != null)
            {
                currentLight.enabled = false; // Ensure light is OFF until grabbed
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jewelry") && currentLight != null)
        {
            currentLight.enabled = false; // Turn light OFF when leaving range
            currentLight = null;
        }
    }
}
