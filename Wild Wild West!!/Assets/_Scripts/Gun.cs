using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawn;
    public Rigidbody bullet;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shooting", 1, 0.5f);
    }

    // Update is called once per frame
    void Shooting()
    {

        Rigidbody bulletRigidbody;
        bulletRigidbody = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation) as Rigidbody;
        bulletRigidbody.AddForce(bulletSpawn.forward * bulletSpeed);


    }

}
