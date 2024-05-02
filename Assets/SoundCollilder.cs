using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundCollilder : MonoBehaviour
{
    AudioSource audioSource; // Reference to the AudioSource component
    [SerializeField] string _triggerTag;
    [SerializeField] AudioClip _triggerClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Check if AudioSource is assigned
        if (audioSource == null)
        {
            Debug.LogError("AudioSource not assigned in SoundOnTriggerEnter script!");
            enabled = false; // Disable the script
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the other collider is tagged as "Player"
        if (other.CompareTag(_triggerTag))
        {
            // Check if the AudioSource is not already playing
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(_triggerClip); // Play the sound
            }
        }
    }
}
