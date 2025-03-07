using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       CamBasedMove();
    }

    void VectorMove()
    {
        pos = transform.position;
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = pos;
    }
    void CamBasedMove()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        Vector3 CameraForward = Camera.main.transform.forward;
        Vector3 CameraRight = Camera.main.transform.right;

        CameraForward.y = 0;
        CameraForward = CameraForward.normalized;
        CameraRight.y = 0;
        CameraRight = CameraRight.normalized;

        // Rotate the Input Vectors 
        Vector3 forwardRelativeMovementVector = ver * CameraForward; 
        Vector3 rightRelativeMovementVector = hor * CameraRight; 
        // Create Camera-Relative Movement Vector 
        Vector3 cameraRelativeMovement = forwardRelativeMovementVector - rightRelativeMovementVector;
        // Move in world space 
        this.transform.Translate(cameraRelativeMovement, Space.World);
    }
}
