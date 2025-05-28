using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform playerTransform;
    public Vector3 offset;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerTransform == null)
        {
            return;
        }

        Vector3 cameraPosition = playerTransform.position + offset;
        float clampX = Mathf.Clamp(cameraPosition.x, minPosition.x, maxPosition.x);
        float clampY = Mathf.Clamp(cameraPosition.y, minPosition.y, maxPosition.y);
        Vector3 clampedCameraPosition = new Vector3(clampX, clampY, cameraPosition.z);
    }
}
