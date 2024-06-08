using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButtonManager : MonoBehaviour
{
    
    public GameObject previousScene;
    public GameObject currentScene;

    public void RestartButton()
    {
        currentScene.SetActive(false);
        previousScene.SetActive(true);
    }
}
