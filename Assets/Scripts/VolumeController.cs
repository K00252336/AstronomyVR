using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    // [SerializeField] private Text volumeText = null;

    void Start()
    {
        if(!PlayerPrefs.HasKey("videoVolume"))
        {
            PlayerPrefs.SetFloat("videoVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("audioVolume");
    }

        private void Save()
    {
        PlayerPrefs.SetFloat("audioVolume", volumeSlider.value);
    }

}