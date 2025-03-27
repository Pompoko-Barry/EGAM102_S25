using UnityEngine;
using UnityEngine.UI;

public class HideButtonClick : MonoBehaviour
{

    public Button instructionsButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instructionsButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        instructionsButton.onClick.RemoveListener(OnButtonClick);

        instructionsButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
