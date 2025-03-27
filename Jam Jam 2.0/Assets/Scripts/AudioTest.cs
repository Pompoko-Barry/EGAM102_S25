using UnityEngine;

public class AudioTest : MonoBehaviour
{
    public AudioClip ping;  
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.clip = ping;
        }
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space) && audioSource != null)
        {
            audioSource.Play();
            Debug.Log("Playing sound");
        }
    }
}