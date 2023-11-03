using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform myTR;
    public GameObject Player;
    private Vector3 Pv = Vector3.zero;
    private Vector3 Cv = new Vector3(0, 2, -3);
    
    void Start()
    {
        myTR = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Pv = Player.transform.position + Cv;
        gameObject.transform.position = Pv;
    }
}
