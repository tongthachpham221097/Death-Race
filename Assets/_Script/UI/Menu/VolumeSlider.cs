using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : BaseVolumeSlider
{
    protected virtual void Start()
    {
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        if (PlayerPrefs.HasKey("Volume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("Volume");
            volumeSlider.value = savedVolume;
            audioSource.volume = savedVolume;
        }
    }

    public void OnVolumeChanged(float value)
    {
        audioSource.volume = value;
        PlayerPrefs.SetFloat("Volume", value);
        if (value == 0) audioSource.mute = true;
        else audioSource.mute = false;

    }
}
