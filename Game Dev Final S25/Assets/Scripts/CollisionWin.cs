using UnityEngine;
using UnityEngine.UI;

public class CollisionWin : MonoBehaviour
{
    public GameObject uiButton;

    private void Start()
    {
        if (uiButton != null)
        {
            uiButton.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (uiButton != null)
        {
            uiButton.SetActive(true);
        }
    }
}
