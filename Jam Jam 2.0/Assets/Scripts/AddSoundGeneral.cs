using UnityEngine;

public class AddSoundGeneral : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayMusic()
    {
        audioSource.Play();
    }

    public void PauseMusic()
    {
        audioSource.Pause();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

}