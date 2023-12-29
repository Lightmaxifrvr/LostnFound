using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayMenu : MonoBehaviour {

public string SampleScene;
public string L1;
public string L2;
public Button[] buttons;

    private void Awake()
    {
        int UnlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i<buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i <UnlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }


    public void OpenLevel(int levelId)

    {
        string levelName = "Level " + levelId;
        SceneManager.LoadScene(levelName);

    }



    public void PlayTutorial () 

 {

  SceneManager.LoadScene (SampleScene);

 }

  public void PlayLevel1 () 

 {

  SceneManager.LoadScene (L1);

 }

    public void PlayLevel2()

    {

        SceneManager.LoadScene(L2);

    }





}