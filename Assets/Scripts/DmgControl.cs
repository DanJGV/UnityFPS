using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DmgControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Image bar;
    [SerializeField]
    float maxHealth;
    [SerializeField]
    public float currentHealth;

    public int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTakeDamage(int damage)
    {
        currentHealth -= damage;
        bar.fillAmount = currentHealth / maxHealth;

    if(currentHealth <= 0)
        {
            SceneManager.LoadScene(index);
        }
    }


}
