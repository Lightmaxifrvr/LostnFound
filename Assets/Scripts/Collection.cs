using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Collection : MonoBehaviour
{
    public int coins = 0;
    public string Scene;

    [SerializeField] TMPro.TextMeshProUGUI coinsText;
    [SerializeField] AudioSource collectionSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coins++;
            Destroy(other.gameObject);
            coinsText.SetText(coins.ToString());
            collectionSound.Play();
        }
    }

    void UnlockNewLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt( "UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }
    void Update()
    {
        if (coins == 10)
        {
            UnlockNewLevel();
            SceneManager.LoadScene(Scene);
        }
    }

}
