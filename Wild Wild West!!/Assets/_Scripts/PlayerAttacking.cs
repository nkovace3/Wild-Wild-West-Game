using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    public GameObject enemy;
    public float targetDistance;
    public RaycastHit shot;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;
        }
        if (targetDistance < 1 && Input.GetMouseButtonDown(0))
        {
            Destroy(enemy);
            //enemy.GetComponent<Animation>().Play("Locomotion");
        }
    }
}
