using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAudioSource : LoboMonoBehaviour
{
    protected AudioSource audioSource;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.audioSource = GetComponent<AudioSource>();
    }
}
