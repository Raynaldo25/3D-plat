using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotMovement : MonoBehaviour
{
    public string sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        if (GameManager.Instance)
        {
            GameManager.Instance.Score = 0;
            GameManager.Instance.endTime = 200;
        }
            SceneManager.LoadScene(sceneToLoad);
        
    }
}
