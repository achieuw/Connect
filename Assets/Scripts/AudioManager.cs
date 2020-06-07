using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    public bool toggleSound = true;

    public enum Sound
    {
        Win,
        Lose,
        Rotate,
    }

    public SoundAudioClip[] soundAudioClipArray;

    [System.Serializable]
    public class SoundAudioClip
    {
        public Sound sound;
        public AudioClip audioClip;
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            Debug.LogError("More than one Audiomanager detected. Delete if multiple on scene");
        }
    }

    public void PlaySound(Sound sound) 
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        if (!toggleSound)
            return;
        else
        {
            audioSource.clip = GetAudioClip(sound);
            audioSource.Play();
            Destroy(soundGameObject, audioSource.clip.length);
        }   
    }

    private AudioClip GetAudioClip(Sound sound)
    {
        foreach (SoundAudioClip soundAudioClip in soundAudioClipArray) {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
                
            }
        }
        Debug.LogError("Sound " + sound + " not found.");
        return null;
    }
}
