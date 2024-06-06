using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMainmenu : MonoBehaviour
{
    public GameObject backToMainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
