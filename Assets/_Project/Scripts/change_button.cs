using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class change_button : MonoBehaviour
{
    public TextMesh A00;
    public TextMesh B0;
    public TextMesh Cin;
    public TextMesh M0;
    public TextMesh M1;
    public TextMesh Cout;
    public TextMesh F0;
    public Material newMaterial;
    public Material oMaterial;
    public MeshRenderer A;
    public MeshRenderer B;
    public MeshRenderer C;
    public MeshRenderer C0;
    public MeshRenderer MU0;
    public MeshRenderer MU1;
    public MeshRenderer MU2;
    public MeshRenderer MU3;
    public MeshRenderer F;
    public MeshRenderer S;
    // public MeshRenderer AIN;
    //public MeshRenderer BIN;
    //public MeshRenderer CIN;
    //public MeshRenderer COUT;
    //public MeshRenderer FO;
    //public MeshRenderer M0I;
    //public MeshRenderer M1I;

    private void Start()
    {
        clearall();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //clearall();
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform != null)
                {
                    // PrintName(hit.transform.gameObject);
                    if (hit.transform.gameObject.name == "A00")
                    {
                        if (A00.text == "1")
                            A00.text = "0";
                        else
                            A00.text = "1";

                    }
                    if (hit.transform.gameObject.name == "B0")
                    {
                        if (B0.text == "1")
                            B0.text = "0";
                        else
                            B0.text = "1";

                    }
                    if (hit.transform.gameObject.name == "Cin")
                    {
                        if (Cin.text == "1")
                            Cin.text = "0";
                        else
                            Cin.text = "1";

                    }
                    if (hit.transform.gameObject.name == "M0")
                    {
                        if (M0.text == "1")
                            M0.text = "0";
                        else
                            M0.text = "1";

                    }
                    if (hit.transform.gameObject.name == "M1")
                    {
                        if (M1.text == "1")
                            M1.text = "0";
                        else
                            M1.text = "1";

                    }
                }
                if (M0.text == "0" && M1.text == "0")
                {
                    clearall();
                    {
                        if (A00.text == "0" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "0";



                        }
                        else if (A00.text == "1" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "1";

                            Colour(A);
                            Colour(MU0);
                            Colour(MU2);
                            Colour(MU3);
                            Colour(F);
                            // Colour(AIN);
                        }
                        else if (A00.text == "0" && B0.text == "1")
                        {
                            Cout.text = "0";
                            F0.text = "1";

                            Colour(B);
                            Colour(MU0);
                            Colour(MU2);
                            Colour(MU3);
                            Colour(F);

                        }
                        else if (A00.text == "1" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "0";

                            Colour(A);
                            Colour(B);

                            Colour(MU1);
                            Colour(MU2);
                            Colour(C0);

                        }

                    }
                    if (Cin.text == "1")
                    {
                        //Colour(CIN);
                        Colour(C);
                        if (A00.text == "0" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "1";
                            Colour(MU0);
                            Colour(F);

                        }
                        else if (A00.text == "1" && B0.text == "0")
                        {
                            Cout.text = "1";
                            F0.text = "0";
                            Colour(MU2);
                            Colour(MU3);
                            Colour(A);
                            Colour(C0);

                        }
                        else if (A00.text == "0" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "0";
                            Colour(MU2);
                            Colour(MU3);
                            Colour(B);
                            Colour(C0);

                        }
                        else if (A00.text == "1" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "1";
                            Colour(MU2);
                            Colour(MU0);
                            Colour(MU1);
                            Colour(A);
                            Colour(B);
                            Colour(C0);
                            Colour(F);

                        }

                    }





                }
                if (M0.text == "0" && M1.text == "1")
                {
                    clearall();
                    Colour(S);
                    if (Cin.text == "0")
                    {

                        if (A00.text == "0" && B0.text == "1")
                        {
                            Cout.text = "0";
                            F0.text = "0";
                            Colour(B);
                            Colour(MU0);
                            Colour(MU2);
                            Colour(MU3);


                        }
                        if (A00.text == "1" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "0";
                            Colour(A);
                            Colour(MU0);
                            Colour(MU2);
                            Colour(MU3);


                        }


                        else if (A00.text == "1" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "1";
                            Colour(B);
                            Colour(A);
                            Colour(MU1);
                            Colour(MU2);
                            Colour(F);
                            Colour(C0);

                        }

                    }
                    if (Cin.text == "1")
                    {
                        Colour(C);
                        if (A00.text == "0" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "0";
                            Colour(MU0);
                        }
                        else if (A00.text == "1" && B0.text == "0")
                        {
                            Cout.text = "1";
                            F0.text = "0";
                            Colour(A);
                            Colour(MU2);
                            Colour(MU3);
                            Colour(C0);



                        }
                        else if (A00.text == "0" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "0";
                            Colour(B);
                            Colour(MU2);
                            Colour(MU3);
                            Colour(C0);

                        }

                        else if (A00.text == "1" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "1";
                            Colour(B);
                            Colour(A);
                            Colour(MU0);
                            Colour(MU1);
                            Colour(MU2);
                            Colour(F);
                            Colour(C0);


                        }

                    }





                }
                if (M0.text == "1" && M1.text == "0")
                {
                    clearall();
                    Colour(S);
                    if (Cin.text == "0")
                    {

                        if (A00.text == "0" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "0";

                        }
                        else if (A00.text == "1" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "1";
                            Colour(A);
                            Colour(MU0);
                            Colour(MU2);
                            Colour(MU3);
                            Colour(F);

                        }
                        else if (A00.text == "0" && B0.text == "1")
                        {
                            Cout.text = "0";
                            F0.text = "1";
                            Colour(B);
                            Colour(MU0);
                            Colour(MU2);
                            Colour(MU3);
                            Colour(F);

                        }
                        else if (A00.text == "1" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "1";
                            Colour(B);
                            Colour(A);
                            Colour(MU1);
                            Colour(MU2);
                            Colour(C0);
                            Colour(F);


                        }

                    }
                    if (Cin.text == "1")
                    {
                        Colour(C);
                        if (A00.text == "0" && B0.text == "0")
                        {
                            Cout.text = "0";
                            F0.text = "0";
                            Colour(MU0);

                        }
                        else if (A00.text == "1" && B0.text == "0")
                        {
                            Cout.text = "1";
                            F0.text = "1";
                            Colour(A);
                            Colour(MU3);
                            Colour(MU2);
                            Colour(C0);
                            Colour(F);
                        }
                        else if (A00.text == "0" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "1";
                            Colour(B);
                            Colour(MU3);
                            Colour(MU2);
                            Colour(C0);
                            Colour(F);
                        }
                        else if (A00.text == "1" && B0.text == "1")
                        {
                            Cout.text = "1";
                            F0.text = "1";
                            Colour(B);
                            Colour(A);
                            Colour(MU2);
                            Colour(MU0);
                            Colour(MU3);
                            Colour(C0);
                            Colour(F);
                        }

                    }


                }





            }
            if (M0.text == "1" && M1.text == "1")
            {
                clearall();
                Colour(S);
                if (Cin.text == "0")
                {

                    if (A00.text == "0" && B0.text == "0")
                    {
                        Cout.text = "0";
                        F0.text = "0";

                    }
                    else if (A00.text == "1" && B0.text == "0")
                    {
                        Cout.text = "0";
                        F0.text = "1";
                        Colour(A);
                        Colour(MU2);
                        Colour(MU0);
                        Colour(MU3);
                        Colour(F);
                    }
                    else if (A00.text == "0" && B0.text == "1")
                    {
                        Cout.text = "0";
                        F0.text = "1";
                        Colour(B);
                        Colour(MU2);
                        Colour(MU0);
                        Colour(MU3);
                        Colour(F);

                    }


                    else if (A00.text == "1" && B0.text == "1")
                    {
                        Cout.text = "1";
                        F0.text = "0";
                        Colour(B);
                        Colour(A);
                        Colour(MU2);
                        Colour(MU1);
                        Colour(C0);



                    }

                }
                if (Cin.text == "1")
                {
                    Colour(C);
                    if (A00.text == "0" && B0.text == "0")
                    {
                        Cout.text = "0";
                        F0.text = "0";
                        Colour(MU0);

                    }
                    else if (A00.text == "1" && B0.text == "0")
                    {
                        Cout.text = "0";
                        F0.text = "1";
                        Colour(A);
                        Colour(MU2);
                        Colour(C0);
                        Colour(MU3);
                        Colour(F);
                    }
                    else if (A00.text == "0" && B0.text == "1")
                    {
                        Cout.text = "0";
                        F0.text = "1";
                        Colour(B);
                        Colour(MU2);
                        Colour(C0);
                        Colour(MU3);
                        Colour(F);

                    }


                    else if (A00.text == "1" && B0.text == "1")
                    {
                        Cout.text = "1";
                        F0.text = "0";
                        Colour(B);
                        Colour(A);
                        Colour(MU2);
                        Colour(MU1);
                        Colour(MU0);
                        Colour(C0);



                    }



                }





            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }


    void Colour(MeshRenderer a)
    {

        MeshRenderer meshRenderer = a;


        Material oldMaterial = meshRenderer.material;

        Debug.Log("Applied Material: " + oldMaterial.name);

        meshRenderer.material = newMaterial;
    }
    void Clear(MeshRenderer a)
    {
        MeshRenderer meshRenderer = a;
        Material oldMaterial = meshRenderer.material;
        Debug.Log("Applied Material: " + oldMaterial.name);
        meshRenderer.material = oMaterial;

    }
    void clearall()
    {
        Clear(A);
        Clear(B);
        Clear(C);
        Clear(C0);
        Clear(MU0);
        Clear(MU1);
        Clear(MU2);
        Clear(MU3);
        Clear(F);
        Clear(S);
        //Clear(AIN);
        //Clear(BIN);
        //Clear(CIN);
        //Clear(COUT);
        //Clear(M0I);
        //Clear(AIN);
        // Clear(M1I);

    }
}

