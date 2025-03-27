using UnityEngine;
using System.Collections;

public class GoalDestoyed : MonoBehaviour
{
    //reference to a particle system
    public ParticleSystem fx;
    public AudioClip ping;

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //try to get the audio source component on the game object
        audioSource = GetComponent<AudioSource>();

        //if AudioSource exists, assign the clip
        if (audioSource != null)
        {
            audioSource.clip = ping;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("JamJam"))
        {
            //to play audio on collision
            if (audioSource != null)
            {
                audioSource.Play();

                Debug.Log("Goal audio should be playing");
            }

            //Destroy(this.gameObject);

            foreach (ContactPoint2D contact in collision.contacts)
            {
                //Instantiate your particle system here.It is "new" since I want it to appear in a specific point.
                ParticleSystem pointFX = Instantiate(fx, contact.point, Quaternion.identity);
                pointFX.Play();
            }
            //to play the particles where destoryed object is
            //fx.Play();

            StartCoroutine(DestroyGoal());
        }
    }
    private IEnumerator DestroyGoal()
    {
        //wait xx seconds
        yield return new WaitForSeconds(0.3f);

        Destroy(this.gameObject);
    }


}
