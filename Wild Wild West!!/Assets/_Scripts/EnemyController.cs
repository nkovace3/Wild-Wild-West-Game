using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float targetDistance;
    public RaycastHit shot;
    public float followSpeed = 0;
    float attack = 0;

    Animator animl;
    private void Awake()
    {

        animl = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        transform.LookAt(player.transform);        //move towards the player
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;
        }
        if (targetDistance >= 1.5)
        {
            followSpeed = 0.2f;
            //enemy.GetComponent<Animation>().Play("Locomotion");
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, followSpeed);
        }
        else
        {
            animl.SetTrigger("Kick");
            followSpeed = 0;
        }
       
    }
    
}
