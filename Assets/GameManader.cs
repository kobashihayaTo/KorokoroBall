using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManader : MonoBehaviour
{
    private int coinCount;

    private void Start()
    {
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

        Debug.Log("CoinCount:" + coinCount);
    }
}
