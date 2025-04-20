using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   public void LoadStartScene(string StartScene)
    {
        SceneManager.LoadScene("Start Scene");
    }

    public void LoadInstructions (string Instructions)
    {
        SceneManager.LoadScene("Instructions Scene");
    }

    public void LoadGame (string Game)
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadWin (string Win)
    {
        SceneManager.LoadScene("Win Scene");
    }
}
