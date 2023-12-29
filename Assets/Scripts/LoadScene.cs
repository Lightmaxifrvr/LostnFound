using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string levelName;


    public void OnTriggerEnter()
    {

        new WaitForSeconds(1);
        SceneManager.LoadScene(levelName);
    }


    public void OnTriggerExit()
    {
        new WaitForSeconds(1);
        SceneManager.LoadScene(levelName);
    }


}