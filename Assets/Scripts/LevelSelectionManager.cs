using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionManager : MonoBehaviour
{

    public LevelData[] levels;


    public LevelData currentlevel;

    private int index = 0;

   

    void Start()
    {
        currentlevel = levels[index];
        
    }

    void Update()
    {
        SwitchLevels();

    }

    public void SwitchLevels()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            index--;
            if (index < 0)
            {
                index = levels.Length - 1;
            }
            currentlevel = levels[index];
            Debug.Log("currentlevel: " + currentlevel.name);
            

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            index++;
            if (index> levels.Length - 1)
            {
                index = 0;
            }
            currentlevel = levels[index];
            Debug.Log("currentlevel: " + currentlevel.name);

        }
    }
}
