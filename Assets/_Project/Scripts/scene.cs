using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public GameObject one;
    public GameObject two;

    // Start is called before the first frame update
     public void Go()
    {
        one.SetActive(false);
        two.SetActive(true);
        

     
    }

    public void loadScene(int number)
    {
        SceneManager.LoadScene(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
