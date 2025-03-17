using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class end : MonoBehaviour
{
    public TextMeshProUGUI ScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "Score: " + GameManager.Instance.Score;
    }
}
