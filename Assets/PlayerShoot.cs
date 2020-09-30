using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    Transform gunBarrel;

    [SerializeField]
    Image bar;
    int ammo = 20;
    // Start is called before the first frame update
    void Start()
    {
        updateHUD();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Vector3 bulletDirection = transform.forward * bulletSpeed;

            if (ammo > 0)
            {
                GameObject b = Instantiate(bullet, gunBarrel.position, transform.rotation);
                b.GetComponent<Rigidbody>().velocity = bulletDirection;

                ammo -= 1;
                updateHUD();
            }
        }
    }

    void updateHUD()
    {
        bar.fillAmount = (float)ammo / 20;
    }
}
