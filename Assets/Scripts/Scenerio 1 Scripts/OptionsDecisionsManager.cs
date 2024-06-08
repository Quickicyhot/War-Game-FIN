 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsDecisionsManager : MonoBehaviour
{
    public GameObject currentScene;
    public GameObject option2;
    public GameObject option1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Option1()
    {
        currentScene.SetActive(false);
        option1.SetActive(true);
    }
    public void Option2()
    {
        currentScene.SetActive(false);
        option2.SetActive(true);
    }
}
