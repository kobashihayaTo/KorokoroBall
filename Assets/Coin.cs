using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManader gameManader;

    private void Start()
    {
        GameObject gameManaderObject = GameObject.Find("GameManager");
        gameManader = gameManaderObject.GetComponent<GameManader>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManader.AddCoinCount();
            Destroy(gameObject);
        }
    }
}
