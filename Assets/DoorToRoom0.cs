using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    private bool playerInRange = false;

    public GameObject additionalObject;

    public string sceneToLoad;

    void Start()
    {
        if (additionalObject != null)
        {
            additionalObject.SetActive(false);
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            EnterDoor();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;

            Debug.Log("Player Entered Door Trigger Zone");

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

            Debug.Log("Player Left Door Trigger Zone");


            if (additionalObject != null)
            {
                additionalObject.SetActive(false);
            }
        }
    }


    void EnterDoor()
    {

        Debug.Log("Player Entered Door");


        if (!string.IsNullOrEmpty(sceneToLoad))
        {

            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("Scene to load is not specified in the DoorScript.");
        }
    }
}
