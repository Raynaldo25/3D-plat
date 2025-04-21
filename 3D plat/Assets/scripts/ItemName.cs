using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemName : MonoBehaviour
{
    public string Itemname;

    public PlayerMovement myPlayer;
    // Start is called before the first frame update
    void Start()
    {

        myPlayer = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayer.addItem(Itemname);
        
    }
}
