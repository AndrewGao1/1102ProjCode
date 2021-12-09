using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject myButton;
    //private void Start()
    //{
       // myButton.SetActive(false);
    //}
    public void TriggerDialogue()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        myButton.SetActive(false);
    }

}
