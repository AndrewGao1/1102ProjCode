using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skull : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePop;
    private void OnTriggerEnter2D(Collider2D other)
    {
        dialoguePop.SetActive(true);
        Destroy(dialoguePop, 5);

    }
}
