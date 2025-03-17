using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI ScoreDisplay;
    public TextMeshProUGUI TimeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "Score: " + GameManager.Instance.Score;
        TimeDisplay.text = "Time: " + GameManager.Instance.endTime;
    }
}
