using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    
    [SerializeField]
    int goToLevel = 0;
    [SerializeField]
    int goalScore = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.instance.score == goalScore)
        {
            SceneManager.LoadScene(goToLevel);
            GameManager.instance.score = 0;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        SceneManager.LoadScene(goToLevel);
        GameManager.instance.score = 0;


    }
}
