using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public GameManager GM;

    public TextMeshProUGUI ScoreDisplay;
    public TextMeshProUGUI Time;

    public Image Coin1;
    public Image Coin2;
    public Image Coin3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "Score: " + GameManager.Instance.Score;
        Time.text = "Time: " + GameManager.Instance.endTime;

        if(GameManager.Instance.Coin1 == true)
        {
            Coin1.enabled = true;
        }
        else
        {
            Coin1.enabled = false;
        }

        if (GameManager.Instance.Coin2 == true)
        {
            Coin2.enabled = true;
        }
        else
        {
            Coin2.enabled = false;
        }

        if (GameManager.Instance.Coin3 == true)
        {
            Coin3.enabled = true;
        }
        else
        {
            Coin3.enabled = false;
        }
    }
}
