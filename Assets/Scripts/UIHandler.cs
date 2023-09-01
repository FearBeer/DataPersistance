using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIHandler : MonoBehaviour
{
    public TMP_InputField playerNameField;
    // Start is called before the first frame update
    void Start()
    {
        SetPlayerName();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetPlayerName()
    {
        if (playerNameField != null)
        {
            if(string.IsNullOrWhiteSpace(playerNameField.text))
            {
                DataManager.instance.playerName = "Unknown";
            } else
            {
                DataManager.instance.playerName = playerNameField.text;
            }
        }
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
