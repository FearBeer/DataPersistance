using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitTheGame()
    {
        if (Application.isEditor)
        {
            EditorApplication.ExitPlaymode();
        }
        else
        {
            Application.Quit();
        }
    }
}
