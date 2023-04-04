using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class DisplayInfo : MonoBehaviour
{
    // public GameObject panel; // Reference to the panel GameObject
    // public Button closeButton; // Reference to the close button in the panel

    // private bool panelIsOpen = false; // Flag to keep track of whether the panel is currently open or closed

    // void Start()
    // {
    //     panel.SetActive(false); // Start with the panel deactivated
    //     closeButton.gameObject.SetActive(false); // Start with the close button deactivated
    //     closeButton.onClick.AddListener(ClosePanel); // Add a listener to the close button
    // }

    // void Update()
    // {
    //     // Check for a mouse click on the object this script is attached to
    //     if (Input.GetMouseButtonDown(0) && !panelIsOpen)
    //     {
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //         RaycastHit hit;
    //         if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
    //         {
    //             panel.SetActive(true); // Activate the panel
    //             closeButton.gameObject.SetActive(true); // Activate the close button
    //             panelIsOpen = true; // Set the flag to true
    //         }
    //     }
    // }

    // public void ClosePanel()
    // {
    //     panel.SetActive(false); // Deactivate the panel
    //     closeButton.gameObject.SetActive(false); // Deactivate the close button
    //     panelIsOpen = false; // Set the flag to false
    // }

    public GameObject panel; // Reference to the panel GameObject
    public Button closeButton; // Reference to the close button in the panel

    private Animator panelAnimator; // Reference to the Animator component of the panel
    private bool panelIsOpen = false; // Flag to keep track of whether the panel is currently open or closed

    void Start()
    {
        // Get the Animator component of the panel
        panelAnimator = panel.GetComponent<Animator>();

        // Set up the OnClick listener for the 3D object
        gameObject.GetComponent<Button>().onClick.AddListener(TogglePanel);

        // Set up the OnClick listener for the close button
        closeButton.onClick.AddListener(TogglePanel);
    }

    void TogglePanel()
    {
        // Invert the state of the panel (open if closed, close if open)
        panelIsOpen = !panelIsOpen;

        // Set the appropriate trigger for the Animator component
        panelAnimator.SetTrigger(panelIsOpen ? "Open" : "Close");
    }
}