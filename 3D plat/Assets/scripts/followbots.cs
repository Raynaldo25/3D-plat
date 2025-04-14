using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followbots : bullet
{
    
    public GameObject targetTower;
    

    public PlayerMovement myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerMovement>();
        targetTower = GameObject.FindWithTag("p1");
    }

    // Update is called once per frame
    void Update()
    {
        if (myPlayer.onTarget == true)
        {
            transform.position += VectorToTower() * speed;
        }
    }



 

    Vector3 VectorToTower()
    {
        Vector3 targetDirection;
        targetDirection = targetTower.transform.position - transform.position;
        targetDirection = targetDirection.normalized;
        return targetDirection;

    }
}
