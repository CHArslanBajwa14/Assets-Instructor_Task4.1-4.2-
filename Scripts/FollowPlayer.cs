using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed;
    //speed by which enemy will chase player
    private Rigidbody enemmyRb;
    //physics component of enemy
    public GameObject player;
    //adding player gameobject
    // Start is called before the first frame update
    void Start()
    {
        enemmyRb=GetComponent<Rigidbody>();
        //getting rigidbody component for the enemy
        player=GameObject.Find("Player");
        //finding player by using name
    }

    // Update is called once per frame
    void Update()
    {
        enemmyRb.AddForce((player.transform.position-transform.position).normalized*speed);
        //enemy will chase the player
    }
}
