using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene11 : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;

    private bool iscooltime = false;

    private float currentTime = 5f;
    private float delayTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(iscooltime)
        {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime/delayTime;
            if(currentTime<=0)
            {
                iscooltime = false;
                currentTime = delayTime;
                img_name.fillAmount = currentTime;
            }
        }
    }

    public void Change()
    {
        txt_name.text = "변경됨";
        iscooltime = true;
    }
}
