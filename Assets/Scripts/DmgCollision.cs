﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgCollision : MonoBehaviour
{
    public DmgControl bar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "DmgObject")
        {
            if(bar)
            {
                bar.onTakeDamage(1);
            }
        }
    }
}
