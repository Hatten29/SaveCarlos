using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dur1 : MonoBehaviour
{
    private bool enterAllowed;
    private string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.GetComponent<dur1>())
        {
            sceneToLoad = "rom1";
            enterAllowed = true;
        }
        else if (collison.GetComponent<dur2>())
        {
            sceneToLoad = "mainhall";
            enterAllowed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collison)
    {
        if (collison.GetComponent<dur1>() || collison.GetComponent<dur2>())
        {
            enterAllowed = false;
        }
    }

    private void Update()
    {
        if (enterAllowed && Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneToLoad);
        }



    }
}
