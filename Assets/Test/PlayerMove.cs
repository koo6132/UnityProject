using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rig;
    private Transform myT;
    private Vector3 mv = Vector3.zero;
    float speed = 5.0f;
    float X;
    float Z;
    bool Isjump;
    public float jumpF;

    private Vector3 mymouce = Vector3.up;
    float mspeed;
    float mouseR;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        myT = GetComponent<Transform>();
        Isjump = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !Isjump)
        {
            rig.AddForce(new Vector3(0, jumpF, 0), ForceMode.Impulse);
            Isjump = true;
        }
        mouseR = Input.GetAxis("Mouse X");
        Z = Input.GetAxis("Vertical");
        X = Input.GetAxis("Horizontal");
        mv.x = X;
        mv.z = Z;
        myT.Translate(mv * speed * Time.deltaTime);
        myT.Rotate(mymouce * mspeed * Time.deltaTime * mouseR);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
            Isjump = false;

    }
}