using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGeneration : MonoBehaviour
{
    // Start is called before the first frame update
    public int NumberOfCubes = 10;
    public int CubeHeightMax = 10;
    public GameObject[] Cubes;

    void InitializeRandom()
    {
        Cubes = new GameObject[NumberOfCubes];

        for (int i = 0; i < NumberOfCubes; i++)
        {
            int randomNumber = Random.Range(1, CubeHeightMax + 1);

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(0.9f, randomNumber, 1);
            cube.transform.position = new Vector3(i, randomNumber / 2.0f, 0);

            cube.transform.parent = this.transform;

            Cubes[i] = cube;
        }
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        //transform.position = new Vector3(-NumberOfCubes / 2f, -CubeHeightMax / 2.0f, 0);
    }

    IEnumerator SelectionSort(GameObject[] unsortedList)
    {
        int min;
        GameObject temp;
        Vector3 tempPosition;
        for (int i = 0; i < unsortedList.Length; i++)
        {
            min = i;
            yield return new WaitForSeconds(1);

            for (int j = i + 1; j < unsortedList.Length; j++)
            {
                if (unsortedList[j].transform.localScale.y < unsortedList[min].transform.localScale.y)
                {
                    min = j;
                }
            }
            LeanTween.color(unsortedList[min], Color.red, 1f);
            LeanTween.color(unsortedList[i], Color.blue, 1f);

            if (min != i)
            {
                yield return new WaitForSeconds(1);

                temp = unsortedList[i];
                unsortedList[i] = unsortedList[min];
                unsortedList[min] = temp;

                tempPosition = unsortedList[i].transform.localPosition;

                LeanTween.moveLocalX(unsortedList[i], unsortedList[min].transform.localPosition.x, 1);
                LeanTween.moveLocalZ(unsortedList[i], -3, 0.5f).setLoopPingPong(1);
                LeanTween.moveLocalX(unsortedList[min], tempPosition.x, 1);
                LeanTween.moveLocalZ(unsortedList[min], 3, 0.5f).setLoopPingPong(1);

                yield return new WaitForSeconds(2);
                LeanTween.color(unsortedList[i], Color.green, 1f);
                LeanTween.color(unsortedList[min], Color.white, 1f);
            }
            else
            {
                LeanTween.color(unsortedList[i], Color.green, 1f);
            }
        }
    }
    
    public void StartSort()
    {
        InitializeRandom();
        StartCoroutine(SelectionSort(Cubes));
    }
}
