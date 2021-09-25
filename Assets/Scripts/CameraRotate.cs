using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 400f;
    private float _xRotation = 0f;
    
    void Update()
    {
        MouseLook();
    }

    void MouseLook()
    {
        float mouseY = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -50f, 50f);
        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);        
    }
}
