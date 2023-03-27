using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class value_address : MonoBehaviour
{
    [SerializeField]
    private float value;
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private InputField delinputField;
    [SerializeField]
    Material M;
    [SerializeField]
    private List<raycasting> instantiatelist;
    public GameObject[] Cylinders;
    public GameObject[] test=new GameObject[40];
    
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        dynamicarray da = GetComponent<dynamicarray>();
        da.InstantiatingLinkedlist += Setblockvalue;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Setblockvalue(float position,int value,int add)
    {

        this.value = value;
        instantiatelist.Add( Instantiate(cube, new Vector3(position, 1f, 0f), Quaternion.identity).GetComponent<raycasting>().SetValueAndAddress((int)value, add));
        
       InitializeCylinder(position,1f,0f,instantiatelist[instantiatelist.Count-1].transform.gameObject);
        if (i > 1)
        {
            StartCoroutine(Grow(test, i-1));


        }


    }
    IEnumerator Colorchange(raycasting var,int i)
    {
        //yield return new WaitForSeconds(1.0f);
        var.GetComponent<MeshRenderer>().material.color = M.color;
        instantiatelist.Remove(instantiatelist[i]);
        yield return new WaitForSeconds(1.0f);
        Destroy(var.gameObject);
    }
   public void Deletion()
    {

        i--;
        StartCoroutine(unGrow(test, i));


        
        for (int i=0;i<instantiatelist.Count;i++)
        {   

            if (delinputField.text == instantiatelist[i].Getaddress())
            {
                raycasting temp = instantiatelist[i];
                StartCoroutine(Colorchange(temp, i));
                break;
            }
            //Debug.Log("deletion happened");
        }
    }
    void InitializeCylinder(float x,float y,float z,GameObject node)
    {
        Cylinders = new GameObject[40];

        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.localScale = new Vector3(.1f, .1f, .1f);
        cylinder.transform.Rotate(0, 0, 90f, Space.Self);
        //cylinder.transform.position = new Vector3(x,y,z);
        cylinder.transform.position = node.transform.Find("nodecenter").transform.position;
        cylinder.name = "cylinder";

        Cylinders[i] = cylinder;
        test[i] = cylinder;

        //transform.position = new Vector3(-i / 1f, 0, 0);
         cylinder.transform.parent = node.transform;
        i++;
    }
    IEnumerator Grow(GameObject[] pointers, int j)
    {
        yield return new WaitForSeconds(1);
        LeanTween.scaleY(pointers[j - 1], 0.0024f, 1f);
        LeanTween.moveLocalX(pointers[j - 1], pointers[j - 1].transform.localPosition.x + 0.0024f, 1f);
    }
    IEnumerator unGrow(GameObject[] pointers, int j)
    {
        yield return new WaitForSeconds(1);
        LeanTween.scaleY(pointers[j - 1], 0.00001f, 1f);
        LeanTween.moveLocalX(pointers[j - 1], pointers[j - 1].transform.localPosition.x -0.0024f, 1f);
        yield return new WaitForSeconds(5);
    }

}
