using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    // Start is called before the first frame update
    public void back()
    {

        one.SetActive(false);
        two.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
