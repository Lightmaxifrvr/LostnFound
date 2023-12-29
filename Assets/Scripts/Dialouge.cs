using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialouge : MonoBehaviour
{

    public GameObject En;
    public GameObject Dis;
    public GameObject Txt;
    public AudioSource m_MyAudioSource;


    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("space key was pressed");
            m_MyAudioSource.Play();
            En.SetActive(true);
            Dis.SetActive(false);
            Txt.SetActive(false);

        }
    }
}