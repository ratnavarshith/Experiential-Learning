using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class Bubble_menu : MonoBehaviour
{
    public Bubble_CubeGeneration SelectionSort;
    public Bubble_CubeGeneration ActiveSorter;
    public InputField InputNumberOfCubes;
    public void StartSort()
    {
        //ActiveSorter = Instantiate(SelectionSort);
        ActiveSorter = GameObject.FindGameObjectWithTag("placer").GetComponent<Bubble_CubeGeneration>();
        ActiveSorter.NumberOfCubes = Convert.ToInt32(InputNumberOfCubes.text);
        ActiveSorter.StartSort();
    }

    public void ResetSorter()
    {
        Destroy(ActiveSorter.gameObject);
    }
}
