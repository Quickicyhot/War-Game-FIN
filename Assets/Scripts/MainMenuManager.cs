using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenuManager : MonoBehaviour
{
    //Menu object references
    public GameObject mainMenu;
    public GameObject aboutMePanel;
    public GameObject levelSelectionPanel;
    public GameObject mainMenuBackground;
    //3d References
    public Camera mainCamera;
    public Camera uiCamera;
    public GameObject threeDlevelSelectionMenu;
    public Transform cameraOriginalPosition;


    //Activates and Deactivates The EnterLevelSelection
    public void EnterLevelSelection()
    {
        mainCamera.orthographic = false;
        uiCamera.orthographic = false;

        threeDlevelSelectionMenu.SetActive(true);
        mainMenu.SetActive(false);
        mainMenuBackground.SetActive(false);
        aboutMePanel.SetActive(false);
        levelSelectionPanel.SetActive(true);
        mainCamera.transform.position = cameraOriginalPosition.position;
        mainCamera.transform.rotation = cameraOriginalPosition.rotation;
    }
    public void ExitLevelSelectionMenu()
    {
        mainMenu.SetActive(true);
        mainMenuBackground.SetActive(true);
        levelSelectionPanel.SetActive(false);
        threeDlevelSelectionMenu.SetActive(false);
        mainCamera.orthographic = true;
        uiCamera.orthographic = true;

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

    public void Start()
    {
        mainCamera = Camera.main;
        mainCamera.orthographic = true;
        uiCamera.orthographic = true;
        threeDlevelSelectionMenu.SetActive(false);
        mainCamera.transform.position = cameraOriginalPosition.position;
        mainCamera.transform.rotation = cameraOriginalPosition.rotation;

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
            threeDlevelSelectionMenu.SetActive(false);
            mainCamera.orthographic = true;
            uiCamera.orthographic = true;

        }


    }
   
}
