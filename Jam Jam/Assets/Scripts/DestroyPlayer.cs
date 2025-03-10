using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject hiddenRestartButton;

void Start ()
{
    if (hiddenRestartButton != null)
    {
        hiddenRestartButton.SetActive(false);
    }
}
   void OnCollisionEnter2D(Collision2D collision)
   {
    if (collision.gameObject.CompareTag("Player"))
        Destroy(collision.gameObject);

    //reveal the hidden restart button
    if (hiddenRestartButton != null)
    {
        hiddenRestartButton.SetActive(true);
    }
   }
}
