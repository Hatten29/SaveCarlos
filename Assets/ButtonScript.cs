using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    private bool playerInRange = false;

    public Image diaryImage;

    public Button[] uiButtons;

    public GameObject additionalObject;

    void Start()
    {
        if (diaryImage != null)
        {
            diaryImage.enabled = false;
        }

        foreach (var button in uiButtons)
        {
            if (button != null)
            {
                button.gameObject.SetActive(false);
            }
        }

        if (additionalObject != null)
        {
            additionalObject.SetActive(false);
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            HandleButtonClick();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;

            Debug.Log("Player Entered Trigger Range");

            if (additionalObject != null)
            {
                additionalObject.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;

            if (diaryImage != null)
            {
                diaryImage.enabled = false;
            }

            foreach (var button in uiButtons)
            {
                if (button != null)
                {
                    button.gameObject.SetActive(false);
                }
            }

            if (additionalObject != null)
            {
                additionalObject.SetActive(false);
            }
        }
    }

    void HandleButtonClick()
    {
        Debug.Log("Button Clicked");

        if (diaryImage != null)
        {
            diaryImage.enabled = true;
        }

        foreach (var button in uiButtons)
        {
            if (button != null)
            {
                button.gameObject.SetActive(true);
            }
        }
    }
}
