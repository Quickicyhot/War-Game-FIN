using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitExplanationScript : MonoBehaviour
{
    public GameObject exitExplanation;
    public GameObject enterExplanation;
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
        exitExplanation.SetActive(false);
    }
    public void EnterExplanation()
    {
        enterExplanation.SetActive(true);
    }
}
