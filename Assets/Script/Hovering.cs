using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hovering : MonoBehaviour
{
    public GameObject infoPanel;        // Info panel that appears on selection
    public AudioClip audioClip;         // Audio to play on selection
    public AudioSource audioSource;     // Audio source to play the clip

    void Start()
    {
        // Ensure info panel is disabled at start
        if (infoPanel != null)
            infoPanel.SetActive(false);
    }

    // Called when the prefab is selected (using XR interaction)
    public void OnSelectEnter()
    {
        // Show the info panel
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);  // Display the relevant info panel for the selected object
        }

        // Play the audio clip
        if (audioClip != null && audioSource != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }

    // Optional: Hide the panel when deselected (if needed)
    public void OnSelectExit()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(false);  // Hide the panel on deselection
        }
    }
}
