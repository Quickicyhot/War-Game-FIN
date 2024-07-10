 

using UnityEngine;
using TMPro;

public class OptionsDecisionsManager : MonoBehaviour
{
    public GameObject currentScene;
    public GameObject option2;
    public GameObject option1;
    public GameObject popupmenu;
    public TMP_Text popuptext;
    public string option1Text;
    public string option2Text;
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
    public void Option1Popup()
    {
        popupmenu.SetActive(true);
        popuptext.text = option1Text;
    }
    public void Option2Popup()
    {
        popupmenu.SetActive(true);
        popuptext.text = option2Text;

    }
    public void ClosePopup()
    {
        popupmenu.SetActive(false);
    }
}
