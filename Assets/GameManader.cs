using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManader : MonoBehaviour
{
    private int coinCount;
    public Text textComponent;

    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

   
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    public void AddCoinCount()
    {
        coinCount = coinCount + 1;

        Debug.Log("CoinCount:" + coinCount.ToString());

        textComponent.text = "CoinCount:" + coinCount.ToString();
    }
}
