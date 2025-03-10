using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour
{

    //reference to all objects tagged "Goal" in the scene
    private int totalGoals;
    private int remainingGoals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //telling the program to find all "Goal" tagged objects and to count them
        totalGoals = GameObject.FindGameObjectsWithTag("Goal").Length;
        remainingGoals = totalGoals;
    }

    // this function is called when a "Goal" tagged object is destroyed
    public void GoalDestroyed()
    {
        remainingGoals--; 

        if (remainingGoals <= 0)
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
