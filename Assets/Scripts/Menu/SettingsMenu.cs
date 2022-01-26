using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public void ChangeSoundVolume(float value)
    {
        PlayerPrefs.SetFloat(RegisteryAddresses.SOUND_VOLUME, value);
    }
    public void ChangeMusicVolume(float value)
    {
        PlayerPrefs.SetFloat(RegisteryAddresses.MUSIC_VOLUME, value);
    }
}
