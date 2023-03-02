using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook_JB : MonoBehaviour
{
    public float sensitivity = 5f;
    public float maxYAngle = 150f;
    public float maxXAngle = 1000000000f;

    private float currentRotationX = 0f;
    private float currentRotationY = 0f;
    private Quaternion originalRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        currentRotationX -= mouseY;
        currentRotationX = Mathf.Clamp(currentRotationX, -maxYAngle, maxYAngle);

        currentRotationY += mouseX;
        currentRotationY = Mathf.Clamp(currentRotationY, -maxXAngle, maxXAngle);

        transform.localRotation = originalRotation * Quaternion.Euler(currentRotationX, currentRotationY, 0);
    }
}