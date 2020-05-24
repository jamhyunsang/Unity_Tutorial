using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea] 
    public string dialogue;
    public Sprite cg;
}
public class Scene15 : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;


    public void ShowDialogue()
    {
        sprite_DialogueBox.gameObject.SetActive(true);
        sprite_StandingCG.gameObject.SetActive(true);
        txt_Dialogue.gameObject.SetActive(true);

        count = 0;
        isDialogue = true;
        nextDialogue();
    }
    private void HideDialogue()
    {
        sprite_DialogueBox.gameObject.SetActive(false);
        sprite_StandingCG.gameObject.SetActive(false);
        txt_Dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void nextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {

                if (count < dialogue.Length)
                {
                    nextDialogue();
                }
                else
                { 
                    HideDialogue();
                }
            }    
        }
    }
}
