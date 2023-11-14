using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class radarfalle : MonoBehaviour
{
    public MeshRenderer bpObj;
    public Material redMat;
    public Material blueMat;
    public button tr;
   
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        bpObj = GetComponent<MeshRenderer>();
        tr.onTriggerButton += ChangeMatToNormal;
        




    }

    // Update is called once per frame
    public void ChangeMatToNormal()
    {
        Debug.Log("æ»≥Á«œººø‰");
        
    }
}
