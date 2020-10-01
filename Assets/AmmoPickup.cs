﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoPickup : MonoBehaviour
{
    [SerializeField]
    int ammoCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerShoot>() != null)
        {
            GameManager.instance.addAmmo(ammoCount);
            Destroy(gameObject);
        }
       
    }


}
