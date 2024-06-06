using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject aboutMePanel;
    public GameObject levelSelectionPanel;
    public GameObject mainMenuBackground;
    


    //Activates and Deactivates The EnterLevelSelection
    public void EnterLevelSelection()
    {
        mainMenu.SetActive(false);
        mainMenuBackground.SetActive(false);
        aboutMePanel.SetActive(false);

        levelSelectionPanel.SetActive(true);
    }
    public void ExitLevelSelectionMenu()
    {
        mainMenu.SetActive(true);
        mainMenuBackground.SetActive(true);
        levelSelectionPanel.SetActive(false);
    }
    //Enters and Exits About Me
    public void EnterAboutMe()
    {
        aboutMePanel.SetActive(true);
    }

    public void ExitAboutMe()
    { 
        aboutMePanel.SetActive(false); 
    }

   //Quits Game
    public void QuitGame()
    {
        Application.Quit(0);
    }

    
    //escape key turning off menus
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            mainMenu.SetActive(true);
            mainMenuBackground.SetActive(true);
            aboutMePanel.SetActive(false);
            levelSelectionPanel.SetActive(false);


        }
       

    }
   
}
