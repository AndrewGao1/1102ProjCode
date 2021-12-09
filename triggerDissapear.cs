using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDissapear : MonoBehaviour
{
    [SerializeField] private GameObject Soul;
    [SerializeField] private GameObject dialoguePop;
    //private void Start()
    //{
    // myButton1.SetActive(false);
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        Soul.SetActive(false);
        dialoguePop.SetActive(true);
        Destroy(dialoguePop, 5);
        
    }
}
