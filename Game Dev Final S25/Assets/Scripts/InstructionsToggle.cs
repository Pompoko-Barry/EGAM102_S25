using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InstructionsToggle : MonoBehaviour
{
    public GameObject instructionsPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instructionsPanel != null)
        {
            instructionsPanel.SetActive(false);
        }

    }

    // Update is called once per frame
   
        public void Toggle()
        {
            if (instructionsPanel != null)
            {
                instructionsPanel.SetActive(!instructionsPanel.activeSelf);
            }
        }   
    
}
