using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    Transform gunBarrel;

    /*[SerializeField]
    Image bar;*/

    //[SerializeField]
    //Text ammoDisplay; 


    public int ammo = 20;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        //updateHUD();
    }

    // Update is called once per frame
    void Update()
    {

        
        if(Input.GetButtonDown("Fire1"))
        {
            Vector3 bulletDirection = transform.forward * bulletSpeed;

            if (gameManager.ammunitionCount > 0)
            {
                GameObject b = Instantiate(bullet, gunBarrel.position, transform.rotation);
                b.GetComponent<Rigidbody>().velocity = bulletDirection;

                GameManager.instance.ammunitionCount -= 1;
                //updateHUD();
            }
        }
    }

    /*void updateHUD()
    {
        ammoDisplay.text = "Ammo: " + ammo.ToString();
        //bar.fillAmount = (float)ammo / 20;
    }*/

   

}
