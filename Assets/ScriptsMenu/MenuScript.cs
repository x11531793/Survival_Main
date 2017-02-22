﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public Canvas QuitMenu;
    public Button startText;
    public Button exitText;

	// Use this for initialization
	void Start ()
    {
        QuitMenu = QuitMenu.GetComponent<Canvas>();
        startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        QuitMenu.enabled = false;
	}

    public void ExitPress()
    {
        QuitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void noPress()
    {
        QuitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartGame ()
    {
        SceneManager.LoadScene("enviro");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
