using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAndSound : MonoBehaviour
{
    public List<GameObject> CanvasList;
    int StartI = 0;
    int updateI = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (StartI < 5)
        {
            CanvasList[StartI].SetActive(false);
            StartI++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        while (updateI < 5)
        {
            CanvasList[updateI].SetActive(true);
            CanvasList[updateI].GetComponent<AudioSource>().Play();
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                CanvasList[updateI].SetActive(false);
                updateI++;

            }
        }
    }
}
