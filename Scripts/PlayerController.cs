using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    //speed of player
    private Rigidbody playerRb;
    //getting rigidbody component for the player
    private GameObject focalPoint;
    //focal point
    private float powerupStrength=10.0f;
    //strength by which enemy will be thrown away after collision

    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        focalPoint=GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput=Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward*speed*forwardInput);
       //moving player in vertical direction
       
    }
    private void OnCollisionEnter(Collision collision)
    {
 if(collision.gameObject.CompareTag("Enemy"))
        {
         Rigidbody enemyRigidbody=collision.gameObject.GetComponent<Rigidbody>();
         Vector3 awayFormPlayer=(collision.gameObject.transform.position-transform.position);
         enemyRigidbody.AddForce(awayFormPlayer*powerupStrength,ForceMode.Impulse);
         //throwing enemy away after collision
        }
    }
}
