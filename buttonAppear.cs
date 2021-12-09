using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAppear : MonoBehaviour
{
    [SerializeField] private GameObject myButton1;
    //private void Start()
    //{
       // myButton1.SetActive(false);
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        myButton1.SetActive(true);
        Debug.Log("YOOO");

    }
}
