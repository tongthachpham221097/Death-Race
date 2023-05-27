using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMainMenu : BaseAudioSource
{
    protected virtual void FixedUpdate()
    {
        if (Time.timeScale == 1) this.audioSource.mute = true;
        if(Time.timeScale == 0) this.audioSource.mute = false;
    }
}
