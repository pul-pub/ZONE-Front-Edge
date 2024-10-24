using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Transform cameraObj;
    [SerializeField] private Transform bodyPlayer;
    [SerializeField] private float sensitivity = 2.0f;
    private float _rotationX = 0.0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        bodyPlayer.Rotate(Vector3.up, mouseX, Space.World);

        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        _rotationX -= mouseY;
        _rotationX = Mathf.Clamp(_rotationX, -90.0f, 90.0f);

        cameraObj.localRotation = Quaternion.Euler(_rotationX, cameraObj.localRotation.eulerAngles.y, 0);
    }
}
