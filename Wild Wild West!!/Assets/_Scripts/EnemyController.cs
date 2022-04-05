using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyController : PlayerHealth
{

    public GameObject enemy;
    public float targetDistance;
    public RaycastHit shot;
    public float followSpeed = 0;
    bool playerAlive;
    bool kicked;

    Animator animl;
    private void Awake()
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
        if (targetDistance >= 2)
        {
            followSpeed = 0.2f;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, followSpeed);
        }
        else
        {
            followSpeed = 0;
            if (playerAlive && !kicked)
            {
                Kick();
            }
        }
    }
    //kick
    void Kick()
    {
        float distance = Mathf.Abs(player.transform.position.magnitude - enemy.transform.position.magnitude);
        animl.SetTrigger("Kick");
        if (distance <= 2f)
        {
            Debug.Log(enemy.name);
            DecrementByOne();
        }
        kicked = true;
        Invoke("KickTimer", 1f);
    }

    void KickTimer()
    {
        kicked = false;
    }
}
