using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameAdmin : MonoBehaviour
{
    

    public static GameAdmin Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }

    }


    public void SceneManage()
    {
        SceneManager.LoadScene(2);
    }

}
