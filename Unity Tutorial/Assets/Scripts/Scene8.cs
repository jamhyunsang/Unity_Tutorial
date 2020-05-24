using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secne8 : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.Blend("Scene8-1");
        }
    }
}
