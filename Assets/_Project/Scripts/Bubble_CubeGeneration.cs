using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble_CubeGeneration : MonoBehaviour
{
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

    IEnumerator BubbleSort(GameObject[] unsortedList)
    {
        int x = unsortedList.Length;
        GameObject temp;
        Vector3 tempPosition;
        for (int i = 0; i < unsortedList.Length - 1; i++)
        {
            for (int j = 0; j < unsortedList.Length - 1 - i; j++)
            {
                yield return new WaitForSeconds(1);

                LeanTween.color(unsortedList[j + 1], Color.blue, 1f);
                LeanTween.color(unsortedList[j], Color.blue, 1f);

                if (unsortedList[j+1].transform.localScale.y < unsortedList[j].transform.localScale.y)
                {
                    yield return new WaitForSeconds(1);
                    LeanTween.color(unsortedList[j + 1], Color.red, 1f);
                    yield return new WaitForSeconds(1);

                    temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j + 1];
                    unsortedList[j + 1] = temp;

                    tempPosition = unsortedList[j].transform.localPosition;

                    LeanTween.moveLocalX(unsortedList[j], unsortedList[j + 1].transform.localPosition.x, 1);
                    LeanTween.moveLocalZ(unsortedList[j], -3, 0.5f).setLoopPingPong(1);
                    LeanTween.moveLocalX(unsortedList[j + 1], tempPosition.x, 1);
                    LeanTween.moveLocalZ(unsortedList[j + 1], 3, 0.5f).setLoopPingPong(1);
                }

                yield return new WaitForSeconds(1);
                LeanTween.color(unsortedList[j +1], Color.white, 1f);
                LeanTween.color(unsortedList[j], Color.white, 1f);
            }

            yield return new WaitForSeconds(1);
            LeanTween.color(unsortedList[x - i - 1], Color.green, 1f);
        }
        yield return new WaitForSeconds(1);
        LeanTween.color(unsortedList[0], Color.green, 1f);
    }

    public void StartSort()
    {
        InitializeRandom();
        StartCoroutine(BubbleSort(Cubes));
    }
}
