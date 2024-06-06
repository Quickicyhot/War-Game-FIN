using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class LevelSelectionUiManager : MonoBehaviour
{
    public LevelSelectionManager levelSelectionManager;
    public TMP_Text Title;
    public TMP_Text Description;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateUi();
    }
    public void UpdateUi()
    {
        Description.text = levelSelectionManager.currentlevel.description;
        Title.text = levelSelectionManager.currentlevel.name;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(levelSelectionManager.currentlevel.sceneid);
    }
}
