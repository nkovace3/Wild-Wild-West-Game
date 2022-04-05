using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossController : PlayerHealth
{
    public GameObject enemy;
    public float targetDistance;
    public RaycastHit shot;
    public float followSpeed = 0;
    bool playerAlive;
    bool kicked;

    Animator animl;
    void Awake()
    {
        playerAlive = true;
        kicked = false;
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
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, followSpeed);
        }
        else
        {
            followSpeed = 0;
            if (playerAlive && !kicked)
            {
                Head();
            }
        }
    }

    void Head()
    {
        float distance = Mathf.Abs(player.transform.position.magnitude - enemy.transform.position.magnitude);
        animl.SetTrigger("Head");
        if (distance <= 1.5f)
        {
            Debug.Log(enemy.name);
            DecrementByThree();
        }
        kicked = true;
        Invoke("HeadTimer", 1.5f);
    }

    void HeadTimer()
    {
        kicked = false;
    }
}

