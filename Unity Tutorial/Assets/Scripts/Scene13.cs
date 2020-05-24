using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene13 : MonoBehaviour
{
    [SerializeField] private InputField inmoney;
    [SerializeField] private Text outmoney2;
    // Start is called before the first frame update

    private int currentMoney = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Input()
    {
        currentMoney += int.Parse(inmoney.text);
        outmoney2.text = currentMoney.ToString();
    }
    public void Output()
    {
        currentMoney -= int.Parse(inmoney.text);
        outmoney2.text = currentMoney.ToString();
    }
}
