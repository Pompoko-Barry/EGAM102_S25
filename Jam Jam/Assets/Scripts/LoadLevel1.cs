using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
        
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Level 1");
    }
}
