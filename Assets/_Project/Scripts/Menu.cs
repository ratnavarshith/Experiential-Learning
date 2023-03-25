using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Menu : MonoBehaviour
{
    public CubeGeneration SelectionSort;
    public CubeGeneration ActiveSorter;
    public InputField InputNumberOfCubes;
    public void StartSort()
    {
        //ActiveSorter = Instantiate(SelectionSort);
        ActiveSorter = GameObject.FindGameObjectWithTag("placer").GetComponent<CubeGeneration>();
        ActiveSorter.NumberOfCubes = Convert.ToInt32(InputNumberOfCubes.text);
        ActiveSorter.StartSort();
    }

    public void ResetSorter()
    {
        Destroy(ActiveSorter.gameObject);
    }
}
