using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMainMenu : MonoBehaviour
{

public void OnButtonClick()
{
    SceneManager.LoadScene("Level Select");
}


}

