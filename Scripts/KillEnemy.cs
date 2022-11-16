using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public float enemyPosY=-5.0f;
    //Y posiyion of the enemy
    private GameObject playerSize;
    //code to incerease player size after death of enemy
    // Start is called before the first frame update
    void Start()
    {
       playerSize=GameObject.Find("Player");
       //finding player
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<enemyPosY)
        {
            Destroy(gameObject);
            //destroy enemy after they get below the y position

           playerSize.transform.localScale += new Vector3(1,1f,1f);
           //size of player will incerease after death
        }
    }
}
