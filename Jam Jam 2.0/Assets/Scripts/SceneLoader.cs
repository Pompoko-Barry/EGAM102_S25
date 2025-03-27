using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadLevelSelect(string LevelSelect)
    {
        SceneManager.LoadScene("Level Select");
    }


 public void LoadInstructions(string Instructions)
    {
        SceneManager.LoadScene("Instructions");
    }


   public void LoadLevel1 (string Level1)
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2 (string Level2)
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3 (string Level3)
    { 
        SceneManager.LoadScene("Level 3");
    }

    public void LoadLevel4 (string Level4)
    {
        SceneManager.LoadScene("Level 4");
    }

    public void LoadLevel5 (string Level5)
    {
        SceneManager.LoadScene("Level 5");
    }

    public void Thanks (string Thanks)
    {
        SceneManager.LoadScene("Thanks");
    }
}
