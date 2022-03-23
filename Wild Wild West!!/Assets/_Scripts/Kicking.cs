using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kicking : MonoBehaviour
{
    Animator animl;
    // Start is called before the first frame update
    void Start()
    {
        animl = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animl.SetTrigger("Kick");
        }
    }
}
