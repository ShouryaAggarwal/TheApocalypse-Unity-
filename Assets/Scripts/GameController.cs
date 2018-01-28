using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public int score;
    public int kills;
    public int time;
    public Text countText;
    public Text gameOver;

    // Use this for initialization
    void Start () {
        score = 0;
        kills = 0;
        time = 0;
        SetScore();
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update () {
        score = time + kills;
        SetScore();
    }

   void SetScore()
    {
        countText.text = "Score : " + score.ToString();
    }

    public void Re()
    {
        Invoke("Restart", 2);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
