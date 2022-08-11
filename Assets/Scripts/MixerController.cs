using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer gameAudioMixer;
    public string sound_name;

    public void SetVolumeGame(float sliderValue)
    {
        gameAudioMixer.SetFloat(sound_name, Mathf.Log10(sliderValue) * 20);
    }
    
}
