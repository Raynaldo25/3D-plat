using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemName : MonoBehaviour
{
    public string Itemname;
    public Image coin1;
    public Image coin2;
    public float testTimer = 0;

   // public PlayerMovement myPlayer;
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        testTimer += Time.deltaTime;
        if (testTimer >= 5f) 
        {
            coin1.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // myPlayer.addItem(Itemname);
        Destroy(gameObject);
    }
}
