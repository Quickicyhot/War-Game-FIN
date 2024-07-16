using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeGontroller : MonoBehaviour
{
    public float rotationspeed = 0.01f;
    public float cameraspeed = 1f;
    public LevelSelectionManager levelSelectionManager;
    public Transform Camera;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.parent.rotation*Quaternion.Euler(levelSelectionManager.currentlevel.globeRotation), rotationspeed* Time.deltaTime);
        Camera.rotation = Quaternion.Lerp(Camera.rotation,Quaternion.Euler(levelSelectionManager.currentlevel.cameraRotation), cameraspeed*Time.deltaTime);
        Camera.position = Vector3.Lerp(Camera.position,levelSelectionManager.currentlevel.cameraPosition, cameraspeed*Time.deltaTime);
        PersistantData.instance.score += 1;
    }


}
