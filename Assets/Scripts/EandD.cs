using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EandD : MonoBehaviour
{
    public GameObject objectEnable;


    public void OnTriggerEnter()
    {

        new WaitForSeconds(1);
        objectEnable.SetActive(false);
    }


    public void OnTriggerExit()
    {
        new WaitForSeconds(1);
        objectEnable.SetActive(true);
    }


}