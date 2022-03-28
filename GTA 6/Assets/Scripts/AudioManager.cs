using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private Nextlevel nextlevel;

    public List<AudioClip> audioClipList;

    public static AudioManager instance;

    public AudioSource audioSource;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    public enum AudioCallers
    {
        UIPressButton = 0,
        GameFailed = 1,
        BossAlert = 2,
        BossCracked = 3,
        WoodCracked = 4,
        BossDefeated = 5,
        KnifeHitBoss = 6,
        KnifeHitApple = 7,
        KnifeHitKnife = 8,
        KnifeHitWood = 9,
        KnifeThrow = 10,
        LevelPassed = 11
    }

    public void PlayAudio(AudioCallers audio)
    {
        audioSource.PlayOneShot(audioClipList[(int)audio]);
    }
}
