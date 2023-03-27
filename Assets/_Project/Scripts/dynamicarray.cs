using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class dynamicarray : MonoBehaviour
{
    [SerializeField]
    private InputField inputField;
   
    float positionx = -5f;
    public int address = 100;
    public event Action<float,int,int> InstantiatingLinkedlist;
    // Start is called before the first frame update
    private void Start()
    {
        positionx = this.transform.position.x;
    }
    public void Insert()
    {
        if (InstantiatingLinkedlist != null)
        {

            InstantiatingLinkedlist(positionx,int.Parse(inputField.text), address);
        }
        // InstantiatingLinkedlist?.Invoke(positionx, address);
        positionx = positionx +2f;
        address = address + 100;
        print(address);
    }
}
