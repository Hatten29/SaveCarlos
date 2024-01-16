using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Variable to check if the player is in the trigger zone
    private bool playerInRange = false;

    void Update()
    {
        // Check if the player is in the trigger zone and presses the "E" key
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // Call the method to handle button click
            HandleButtonClick();
        }
    }

    // OnTriggerEnter2D is called when the player enters the trigger zone
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Set playerInRange to true when the player enters the trigger zone
            playerInRange = true;

            // Print a debug message indicating that the player has entered the trigger range
            Debug.Log("Player Entered Trigger Range");
        }
    }

    // OnTriggerExit2D is called when the player exits the trigger zone
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Set playerInRange to false when the player exits the trigger zone
            playerInRange = false;
        }
    }

    // Method to handle the button click
    void HandleButtonClick()
    {
        // Print "Button Clicked" to the console
        Debug.Log("Button Clicked");
    }
}
