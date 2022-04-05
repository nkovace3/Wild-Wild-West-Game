using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bulletSpawn;
    public Rigidbody bullet;
    public float bulletSpeed;
    Animator animl;
    // Start is called before the first frame update
    private void Start()
    {
        animl = GetComponent<Animator>();

        Vector3 randomRotation = new Vector3(Random.Range(30f, 60f), 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody bulletRigidbody;
            bulletRigidbody = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation) as Rigidbody;
            bulletRigidbody.AddForce(bulletSpawn.forward * bulletSpeed);
            Vector3 randomRotation = new Vector3(Random.Range(30f, 60f), 0, 0);
            bulletRigidbody.AddRelativeTorque(randomRotation, ForceMode.Impulse);
        }
        if (Input.GetMouseButtonDown(1))
        {
            animl.SetTrigger("Kick");
        }

    }
}
