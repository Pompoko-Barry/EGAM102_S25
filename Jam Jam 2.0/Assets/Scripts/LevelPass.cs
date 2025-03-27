using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelPass : MonoBehaviour

    //if all items tagged "Goal" are gone then reveal hidden "next level?" button
    //next level button will load the next scene in the build
{

    public Button nextLevel;

    public AudioClip win;

    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //to hide the button on start
        nextLevel.gameObject.SetActive(false);

        //to add a "listener" not entirely sure what this is for
        nextLevel.onClick.AddListener(NextLevel);

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Goal").Length==0)
        {
            GameObject jamJam = GameObject.FindGameObjectWithTag("JamJam");
            if (jamJam != null)
            {
                Destroy(jamJam);
            }

            ShowNextLevel();

            //to play audio
            if (audioSource != null && win != null && !audioSource.isPlaying)
            {
                if (audioSource.clip != win)
                {
                    audioSource.clip = win;
                }

                audioSource.Play();

                Debug.Log("win audio should be playing");
            }
        }
    }

    private void ShowNextLevel()
    {
        nextLevel.gameObject.SetActive(true);
    }

    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
