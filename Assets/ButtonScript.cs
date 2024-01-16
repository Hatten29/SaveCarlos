using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    // Variable to check if the player is in the trigger zone
    private bool playerInRange = false;

    // Reference to the UI image
    public Image uiImage;

    // Reference to the UI button
    public Button uiButton;

    // Array of sprites to toggle between
    public Sprite[] spriteArray;

    // Index to keep track of the current sprite
    private int currentSpriteIndex = 0;

    void Start()
    {
        // Ensure the UI image is initially hidden
        if (uiImage != null)
        {
            uiImage.enabled = false;
        }

        // Subscribe to the button click event
        if (uiButton != null)
        {
            uiButton.onClick.AddListener(OnButtonClick);
        }
    }

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

            // Hide the UI image when the player exits the trigger zone
            if (uiImage != null)
            {
                uiImage.enabled = false;
            }
        }
    }

    // Method to handle the button click
    void HandleButtonClick()
    {
        // Print "Button Clicked" to the console
        Debug.Log("Button Clicked");

        // Show the UI image
        if (uiImage != null)
        {
            uiImage.enabled = true;
        }

        // Toggle between sprites
        if (spriteArray.Length > 0)
        {
            currentSpriteIndex = (currentSpriteIndex + 1) % spriteArray.Length;
            uiImage.sprite = spriteArray[currentSpriteIndex];
        }
    }

    // Method to handle the UI button click
    void OnButtonClick()
    {
        // Handle button click when the UI button is clicked
        Debug.Log("UI Button Clicked");

        // You can add additional logic here if needed
    }
}
