using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCountDown : LoboMonoBehaviour
{
    public AudioSource soundStartUp;
    public AudioSource soundIdle;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSoundStartUp();
        this.LoadSoundIdle();
    }
    protected virtual void LoadSoundStartUp()
    {
        if (this.soundStartUp != null) return;
        this.soundStartUp = GameObject.Find("SoundStartUp").GetComponent<AudioSource>();
        Debug.Log(transform.name + ": LoadSoundStartUp", gameObject);
    }
    protected virtual void LoadSoundIdle()
    {
        if (this.soundIdle != null) return;
        this.soundIdle = GameObject.Find("SoundIdle").GetComponent<AudioSource>();
        Debug.Log(transform.name + ": LoadSoundIdle", gameObject);
    }
    public virtual void PlaySoundCountDown()
    {
        StartCoroutine(PlaySounds());
    }

    IEnumerator PlaySounds()
    {
        this.soundStartUp.Play();
        yield return new WaitForSeconds(this.soundStartUp.clip.length);

        this.soundIdle.Play();
    }
}
