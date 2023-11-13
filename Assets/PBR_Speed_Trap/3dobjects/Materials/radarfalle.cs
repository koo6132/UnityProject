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
   
   
    // Start is called before the first frame update
    void Start()
    {
        
        tr.onTriggerButton += ChangeMatToNormal;





    }

    // Update is called once per frame
    public void ChangeMatToNormal()
    {
        Material[] mat = this.GetComponent<Renderer>().materials;
        mat[1] = bulemat;
        this.GetComponent<Renderer>().materials = mat; 
        
        Debug.Log("æ»≥Á«œººø‰");
        
    }
}
