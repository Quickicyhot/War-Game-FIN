using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsNextManager : MonoBehaviour
{
    public GameObject currentScene;
    public GameObject nextScene;
   
    public void NextScene()
    {
        currentScene.SetActive(false);
        nextScene.SetActive(true);
    }
}
