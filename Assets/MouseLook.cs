using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
	public float mouseSensitivity = 200f;
	public Transform playerBody;
	float xRotate = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() 
    {
        float mX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
		xRotate -= mY;
		xRotate = Mathf.Clamp(xRotate,-90f,90f);
		
		transform.localRotation = Quaternion.Euler(xRotate,0f,0f);
		playerBody.Rotate(Vector3.up * mX);
		
    }
}
