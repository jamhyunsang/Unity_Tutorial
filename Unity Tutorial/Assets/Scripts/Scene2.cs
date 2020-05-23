using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2 : MonoBehaviour
{
    [SerializeField]
    private GameObject go_camera;


    void Update()
    {
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);

    }
}
