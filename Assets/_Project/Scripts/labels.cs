using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labels : MonoBehaviour
{
    public GameObject motor;
    public GameObject start;
    public GameObject next;
    public GameObject next1;
    public List<GameObject> goList;


    void Start()
    {
    }


    public void Split()
    {
        int i = 0;
        motor.GetComponent<Animator>().Play("split");

        while (i < 4)
        {

            goList[i].SetActive(true);
            goList[i].GetComponent<AudioSource>().Play();
            if (Input.GetKey(KeyCode.Mouse0))
            {
                i++;
            }
        }

        start = GameObject.Find("start");

        start.SetActive(false);
        next.SetActive(true);
    }
    public void Rotation()
    {
        int i = 4;
        motor.GetComponent<Animator>().Play("rotation");
        while (i < 6)
        {
            goList[i].SetActive(true);
            goList[i].GetComponent<AudioSource>().Play();
            if (Input.GetKey(KeyCode.Mouse0))
            {
                i++;
            }
        }

        next.SetActive(false);
        next1.SetActive(true);

    }
    public void Com_rot()
    {
        motor.GetComponent<Animator>().Play("com_rotation");

        goList[6].SetActive(true);
        goList[6].GetComponent<AudioSource>().Play();

        next1.SetActive(false);
    }

}
