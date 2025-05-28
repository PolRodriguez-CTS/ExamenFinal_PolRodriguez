using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    public Vector3 offset;
    
    // Start is called before the first frame update
    void Awake()
    { 
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 cameraPosition = playerTransform.position + offset;

        float clampX = Mathf.Clamp(cameraPosition.x, minPosition.x, maxPosition.x);
        float clampY = Mathf.Clamp(cameraPosition.y, minPosition.y, maxPosition.y);

        Vector3 clampedCameraPosition = new Vector3(clampX, clampY, cameraPosition.z);
        gameObject.transform.position = clampedCameraPosition;
        
        if(playerTransform == null)
        {
            return;
        }
    }
}
