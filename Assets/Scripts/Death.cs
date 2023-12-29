using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject objectEnable;


    public void OnTriggerEnter()
    {

        new WaitForSeconds(1);

        objectEnable.SetActive(true);

        Time.timeScale = 0f;
        
        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;
    }


    public void OnTriggerExit()
    {
        new WaitForSeconds(1);

        objectEnable.SetActive(true);

        Time.timeScale = 0f;
        
        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;
        
    }


}