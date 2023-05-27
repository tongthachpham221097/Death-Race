using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseVolumeSlider : LoboMonoBehaviour
{
    [Header("Base Volume Slider")]
    public Slider volumeSlider;
    public AudioSource audioSource;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSlider();
        this.LoadAudioSource();
    }
    protected virtual void LoadSlider()
    {
        this.volumeSlider = GetComponent<Slider>();
    }
    protected virtual void LoadAudioSource()
    {
        if (this.audioSource != null) return;
        this.audioSource = GameObject.Find("SoundMainMenu").GetComponent<AudioSource>();
        Debug.Log(transform.name + ": LoadPauseMenu", gameObject);
    }
}
