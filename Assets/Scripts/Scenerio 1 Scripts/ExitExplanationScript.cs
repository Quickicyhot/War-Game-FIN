using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitExplanationScript : MonoBehaviour
{
   
    public GameObject greyPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitExplanation()
    {
        greyPanel.SetActive(false);
    }
    public void EnterExplanation()
    {
        greyPanel.SetActive(true);
    }
}
