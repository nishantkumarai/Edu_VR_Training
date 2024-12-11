using UnityEngine;
using UnityEngine.UI; // Required for working with UI components

public class ToggleUI : MonoBehaviour
{
    // References to the UI GameObjects
    public GameObject MainUI;
    public GameObject NextUI;

    // Reference to the button
    public Button ToggleButton;

    void Start()
    {
        
        if (ToggleButton != null)
        {
            ToggleButton.onClick.AddListener(SwitchUI);
        }
        else
        {
            Debug.LogError("ToggleButton is not assigned in the Inspector");
        }

        
        if (MainUI == null || NextUI == null)
        {
            Debug.LogError("MainUI or NextUI is not assigned in the Inspector");
        }
    }

    // Method to switch UI panels
    void SwitchUI()
    {
        if (MainUI != null && NextUI != null)
        {
            MainUI.SetActive(false); 
            NextUI.SetActive(true);  
        }
    }
}
