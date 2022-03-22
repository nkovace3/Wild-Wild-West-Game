using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
   public  GameObject enemy;
    public float targetDistance;
    public RaycastHit shot;
    public float followSpeed = 0;
    float attack = 0;

    private void Awake()
    {
        Invoke("Delay", 15);
    }
    private void Delay()
    {
        attack = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (attack == 1)
        {
            transform.LookAt(player.transform);        //move towards the player
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
            {
                targetDistance = shot.distance;
            }
            if (targetDistance >= 5)
            {
                followSpeed = 0.2f;
                //enemy.GetComponent<Animation>().Play("Locomotion");
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, followSpeed);
            }
            else
            {
                followSpeed = 0;
                //if the player is within 1 of each of the x and z positions, he attacks every few seconds

            }
        }


    }

    public void punch()
    {
        //enemy.GetComponent<Animation>().Play("run");
        //punch script

    }
    public void kick()
    {
        //enemy.GetComponent<Animation>().Play("kick");

    }
}
