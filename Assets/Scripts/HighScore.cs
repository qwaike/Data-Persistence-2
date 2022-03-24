using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScore : MonoBehaviour
{
    public static HighScore Instance;
    public TMP_InputField player_input;
    public string playerName;
    public int das_highScore;

    private void Awake()
    {
        //if (Instance != null)
        //{
        //    Destroy(gameObject);
        //    return;
        //}
        //Instance = this;
        //DontDestroyOnLoad(gameObject);

    }

    [System.Serializable]
    class HighScoreData
    {
        public string playerName;
        public int highScore;
    }

    public void SaveHighScore()
    {
        playerName = player_input.text;
        PlayerPrefs.SetString("player", playerName);
        PlayerPrefs.SetInt("high", das_highScore);




        //HighScoreData score_inst = new HighScoreData();
        //score_inst.highScore = das_highScore;
        //score_inst.playerName = player_input.text;
        //Debug.Log(score_inst.playerName);
        //string json_h = JsonUtility.ToJson(score_inst.highScore);
        //string json_playername = JsonUtility.ToJson(score_inst.playerName);


    }

    public void SaveToFile()
    {
    }



    public void StartGame()
    {
        SaveHighScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
