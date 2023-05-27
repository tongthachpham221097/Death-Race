using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BaseSound : MonoBehaviour
{
    protected AudioClip soundClip;

    protected AudioSource audioSource;

    protected virtual void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    protected virtual void PlaySound()
    {
        audioSource.PlayOneShot(soundClip);
    }
}
