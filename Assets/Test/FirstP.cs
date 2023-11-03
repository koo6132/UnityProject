using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstP : MonoBehaviour
{
    private Vector3 mymouce = Vector3.up;
    float mspeed;
    float mouseR;

    public Camera playerCamera;
    public float fov = 60f;
    public bool invertCamera = false;
    public bool cameraCanMove = true;
    public float mouseSensitivity = 2f;
    public float maxLookAngle = 90f;

    // Crosshair
    public bool lockCursor = true;
    public bool crosshair = true;
    public Sprite crosshairImage;
    public Color crosshairColor = Color.white;

    // Internal Variables
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private IEnumerator Start()
    {
        mspeed = 0;
        yield return new WaitForSeconds(0.5f);
        mspeed = 5000.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Cursor.visible = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Cursor.visible = false;
        }
            transform.Rotate(mymouce * mspeed * Time.deltaTime * mouseR);
            mouseR = Input.GetAxis("Mouse X");
        if (cameraCanMove)
        {
            yaw = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity;

            if (!invertCamera)
            {
                pitch -= mouseSensitivity * Input.GetAxis("Mouse Y");
            }
            else
            {
                // Inverted Y
                pitch += mouseSensitivity * Input.GetAxis("Mouse Y");
            }

            // Clamp pitch between lookAngle
            pitch = Mathf.Clamp(pitch, -maxLookAngle, maxLookAngle);

            transform.localEulerAngles = new Vector3(0, yaw, 0);
            playerCamera.transform.localEulerAngles = new Vector3(pitch, 0, 0);
        }
    }
}
