using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDestroyed : MonoBehaviour
{
    private string currentScene;

    //to call the screenshake from script taken from Andrew
    private ScreenShake screenShake;

    //reference to the reset button
    //rember to add the UI using in the top or it will not be able to recognize that you are calling this function
    public Button resetButton;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //Store the current scene name at the start of the game
        currentScene = SceneManager.GetActiveScene().name;

        //to hide the button on start
        resetButton.gameObject.SetActive(false);

        //to add a "listener" not entirely sure what this is for
        resetButton.onClick.AddListener(ResetButton);

        //to find the Camera(or object you want to shake) and get the screenshake associated with it
        screenShake = Camera.main.GetComponent<ScreenShake>();
    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("JamJam tagged colliding");

        if (collision.gameObject.CompareTag("JamJam"))
        {
            Debug.Log("JamJam collided! Destroying...");


            Destroy(collision.gameObject);
            ShowResetButton();

            //call for screen shake
            screenShake.ShakeCamera();
        }
        
    }

    private void ShowResetButton()
    {
        resetButton.gameObject.SetActive(true);

    }

    private void ResetButton()
    {
        SceneManager.LoadScene(currentScene);
    }
}
