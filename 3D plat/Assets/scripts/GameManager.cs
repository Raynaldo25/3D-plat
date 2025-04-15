using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public float endTime = 0f;
    public int Score;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI timerDisplay;

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            endTime = 0f;
            Score = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*scoreDisplay.text = "Score: " + Score;
        timerDisplay.text = "Time: " + endTime;*/

        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            endTime += Time.deltaTime;
        }
        

    }
}
