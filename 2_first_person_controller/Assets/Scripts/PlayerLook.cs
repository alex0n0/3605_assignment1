﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity;
    float xAxisClamp = 0.0f;

    void Awake() 
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
 
        float rotAmountX = mouseX * mouseSensitivity;
        float rotAmountY = mouseY * mouseSensitivity;

        Vector3 targetRotCam = transform.rotation.eulerAngles; 
        targetRotCam.x -= rotAmountY;
        Vector3 targetRotBody = playerBody.rotation.eulerAngles; 
        targetRotBody.y += rotAmountX;

        xAxisClamp -= rotAmountY;
        targetRotCam.z = 0; 
        if (xAxisClamp > 90) { 
            xAxisClamp = 90;
            targetRotCam.x = 90;
        } else if (xAxisClamp < -90) {
            xAxisClamp = -90;
            targetRotCam.x = 270;
        }

        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);
    }
}
