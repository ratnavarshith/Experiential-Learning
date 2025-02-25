using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ARPlacementManager : MonoBehaviour
{
    // Detect User's Touch
    // Project/Shoot a Raycast
    // Instantiate the object where the raycast was shot

    public GameObject sessionOrigin;
    public GameObject _Object;

    public List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    private GameObject instantiatedObject;
    private bool placed = false;

    private void Update()
    {
        if (Input.GetMouseButton(0) && !placed)
        {
            bool collision = sessionOrigin.GetComponent<ARRaycastManager>().Raycast(Input.mousePosition, raycastHits, TrackableType.PlaneWithinPolygon);

            if (collision)
            {

                if (instantiatedObject == null)
                {
                    //_Object.SetActive(true);
                    instantiatedObject = Instantiate(_Object);


                    foreach (var plane in sessionOrigin.GetComponent<ARPlaneManager>().trackables)
                    {
                        plane.gameObject.SetActive(false);
                    }

                    sessionOrigin.GetComponent<ARPlaneManager>().enabled = false;

                }

                instantiatedObject.transform.position = raycastHits[0].pose.position;
                placed = true;
            }

        }
    }

}