using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
    
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    public AudioSource audiosource;

    // Start is called before the first frame update
    private Queue<string> sentences;
    void Start()
        {
            sentences = new Queue<string>();
            audiosource = GetComponent<AudioSource>();

        }

        public void StartDialogue(Dialogue dialogue)
        {
        animator.SetBool("IsOpen", true);
            
            Debug.Log("Starting convo with " + dialogue.name);
            nameText.text = dialogue.name;
            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
    
            }
            DisplayNextSentence();
        }
        public void DisplayNextSentence()
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;

            }
            string sentence = sentences.Dequeue();
            dialogueText.text = sentence;
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }


        IEnumerator TypeSentence(string sentence)
         {
            audiosource.Play();
            dialogueText.text = "";
            foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            
            yield return null;
            
        }
        audiosource.Stop();
        }
        void EndDialogue()
        {
        animator.SetBool("IsOpen", false);
    }


    

}
