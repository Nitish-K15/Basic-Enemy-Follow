using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;

    [SerializeField] Transform cam;
    [SerializeField] Transform orient;

    float mouseX;
    float mouseY;

    float multiplier = 0.01f;

    float Xrotation;
    float Yrotation;

    bool isPause;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");

        Yrotation += mouseX * sensX * multiplier;
        Xrotation -= mouseY * sensY * multiplier;

        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);

        cam.transform.rotation = Quaternion.Euler(Xrotation, Yrotation, 0);
        orient.transform.rotation = Quaternion.Euler(0, Yrotation, 0);
    }
}
