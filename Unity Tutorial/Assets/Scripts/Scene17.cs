using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;

        if(Physics.Raycast(this.transform.position,this.transform.forward,out hitInfo,10f))
        {
            Debug.Log(hitInfo.transform.name);
        }
    }
}
