using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int Score = 0;
    public string ScoreString = "Score";
    public string WinString = " ";

    public Text TextScore;
    public Text TextWin;

    public static GameController Gamecontroller;

    void Awake()
    {
        Gamecontroller = this;
    }
    void Start()
    {
        GameController.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = ScoreString + Score.ToString();
        }


        if ( Score == 10)
        {
            TextWin.text = "You win!";
        }
    }
}
