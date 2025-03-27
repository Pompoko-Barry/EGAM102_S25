using UnityEngine;

public class SwingAudio : MonoBehaviour
{
    public AudioClip swing;

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null)
        {
            audioSource.clip = swing;
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("JamJam"))
        {
            if (audioSource != null)
            {
                audioSource.Play();
                Debug.Log("Swing audio is playing");
            }
        }
    }
}
