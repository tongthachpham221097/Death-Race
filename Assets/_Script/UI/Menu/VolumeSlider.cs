using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : BaseVolumeSlider
{
    protected AudioSource[] audioSources;

    protected virtual void Start()
    {
        audioSources = FindObjectsOfType<AudioSource>();

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);

        if (PlayerPrefs.HasKey("Volume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("Volume");
            volumeSlider.value = savedVolume;
            SetVolume(savedVolume);
        }
    }

    public void OnVolumeChanged(float value)
    {
        SetVolume(value);
        PlayerPrefs.SetFloat("Volume", value);
    }

    private void SetVolume(float value)
    {
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = value;
        }
    }
}
