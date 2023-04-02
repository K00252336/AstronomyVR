using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour
{
    // 1st Code
    public GameObject panel; // Reference to the panel GameObject
    public Button closeButton; // Reference to the close button in the panel

    private bool panelIsOpen = false; // Flag to keep track of whether the panel is currently open or closed

    void Start()
    {
        panel.SetActive(false); // Start with the panel deactivated
        closeButton.gameObject.SetActive(false); // Start with the close button deactivated
        closeButton.onClick.AddListener(ClosePanel); // Add a listener to the close button
    }

    void Update()
    {
        // Check for a mouse click on the object this script is attached to
        if (Input.GetMouseButtonDown(0) && !panelIsOpen)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                panel.SetActive(true); // Activate the panel
                closeButton.gameObject.SetActive(true); // Activate the close button
                panelIsOpen = true; // Set the flag to true
            }
        }
    }

    public void ClosePanel()
    {
        panel.SetActive(false); // Deactivate the panel
        closeButton.gameObject.SetActive(false); // Deactivate the close button
        panelIsOpen = false; // Set the flag to false
    }


    // 2nd Method
    // public GameObject panel;
    // public Button closeButton;

    // private void OnMouseDown()
    // {
    //     ShowPanel();
    // }

    // public void ShowPanel()
    // {
    //     panel.SetActive(true);
    //     closeButton.onClick.AddListener(HidePanel);
    //     GetComponent<BoxCollider>().enabled = false;
    // }

    // public void HidePanel()
    // {
    //     panel.SetActive(false);
    //     closeButton.onClick.RemoveListener(HidePanel);
    //     GetComponent<BoxCollider>().enabled = true;
    // }

}