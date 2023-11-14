using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class radarfalle : MonoBehaviour
{
    public MeshRenderer bpObj;
    public Material zememat;
    public Material redmat;
    public Material bulemat;
    public button tr;
   
<<<<<<< Updated upstream
   
    // Start is called before the first frame update
    void Start()
    {
=======
    
    // Start is called before the first frame update
    void Start()
    {
        tr.onTriggerButton += ChangeMatToNormal;
>>>>>>> Stashed changes
        
        tr.onTriggerButton += ChangeMatToNormal;





    }

    // Update is called once per frame
    public void ChangeMatToNormal()
    {
        Material[] mat = this.GetComponent<Renderer>().materials;
<<<<<<< Updated upstream
        mat[1] = bulemat;
        this.GetComponent<Renderer>().materials = mat; 
        
=======
        mat[1] = blueMat;
        this.GetComponent<Renderer>().materials = mat;
>>>>>>> Stashed changes
        Debug.Log("æ»≥Á«œººø‰");
        
    }
}
