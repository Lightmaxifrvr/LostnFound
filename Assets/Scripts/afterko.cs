using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afterko : MonoBehaviour
{
    public GameObject objectEnable;
    public GameObject objectEnable2;


    public void OnTriggerEnter()
    {
        Invoke("Die", 7);
    }

    void Die()
    {
        objectEnable.SetActive(true);
        objectEnable2.SetActive(true);
        Debug.Log("why the fuck does this not work?");
    }
}