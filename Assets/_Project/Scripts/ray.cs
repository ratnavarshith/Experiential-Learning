using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public GameObject cube;
    public GameObject emp;
    public float speed = 0f;
    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position,cube.transform.position,out RaycastHit info,5f))
        {
            emp.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
        }
    }
}
