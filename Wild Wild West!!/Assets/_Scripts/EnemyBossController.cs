using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float targetDistance;
    public RaycastHit shot;
    public float followSpeed = 0;
    public int playerHealth = 10;
    float attack = 0;
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
        if (playerHealth == 0)
        {
            player.SetActive(false);
            playerAlive = false;

        }

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
            followSpeed = 0;
            if (playerAlive && !kicked)
            {
                Kick();
            }
        }
    }

    void Kick()
    {
        float distance = Mathf.Abs(enemy.transform.position.magnitude - player.transform.position.magnitude);
        animl.SetTrigger("Head");
        if (distance <= 1.5f)
        {
            playerHealth--;
        }
        kicked = true;
        Invoke("KickTimer", 1.5f);
    }

    void KickTimer()
    {
        kicked = false;
    }
}
