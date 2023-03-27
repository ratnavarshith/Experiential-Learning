using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class raycasting : MonoBehaviour
{
    int value; int address;
    [SerializeField]
    TMP_Text[] v_a;

    [SerializeField] LayerMask layermask;
    void Update()
    {
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.right),out RaycastHit hitinfo,5f))
        {
            //Debug.Log("pointed correctly");
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hitinfo.distance, Color.green);

        }
        else
        {
            //Debug.Log("not pointed correctly");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 5f, Color.red);
        }
    }
    public raycasting SetValueAndAddress(int value,int address)
    {

        this.value = value;
        this.address = address;
        //converting int to string
        v_a[0].text = value.ToString();
        v_a[1].text = address.ToString();
        return this;
    }
    public string Getaddress()
    {
        return address.ToString();
    }
}
