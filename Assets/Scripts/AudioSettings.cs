using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource[] backgroundAudio;
    public AudioSource[] soundEffectsAudio;

    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);

        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }

        for (int z = 0; z < backgroundAudio.Length; z++)
        {
            backgroundAudio[z].volume = backgroundFloat;
        }
    }


}
