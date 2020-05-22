using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    static GameAssets Instance;
    public static GameAssets i
    {
        get
        {
            if (Instance == null) Instance = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return Instance;
        }
    }

    public SoundAudioClip[] soundAudioClipArray;

    [System.Serializable]
    public class SoundAudioClip
    {
        public AudioManager.Sound sound;
        public AudioClip audioClip;
    }
}
