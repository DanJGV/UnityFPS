using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, Vector3.down);
        Debug.DrawLine(r.origin, r.origin + (Vector3.down * 10));
        RaycastHit hit;

        if (Physics.Raycast(r, out hit, 10))
        {
            if (hit.transform != null)
            {
                Debug.Log(hit.transform.name);

            }
        }

    }
}
