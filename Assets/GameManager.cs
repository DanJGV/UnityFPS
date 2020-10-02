using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public int goalScore = 3;
    [SerializeField]
    Text scoreText;

    [SerializeField]
    public int ammunitionCount;
    [SerializeField]
    private Text ammunitionCountText;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        if (instance != this)

            Destroy(gameObject);

       // DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        //GUI.Label(new Rect(100, 10, 100, 20), "Targets Destroyed: " + score + "/3");
        scoreText.text = "Targets Destroyed: " + score + "/3";
        ammunitionCountText.text = "Ammo: " + ammunitionCount;
    }
    public void AddScore(int amount)
    {
        score += amount;
      

    }
    public bool ConsumeAmmo()
    {
        if (ammunitionCount > 0)
        {
            ammunitionCount--;
            UpdatedAmmoCountUI();
            return true;
        }
        else
        {
            return false;
        }
    }
    private void UpdatedAmmoCountUI()
    {
        ammunitionCountText.text = "Ammo: " + ammunitionCount;
    }
    public void addAmmo(int value)
    {
        ammunitionCount += value;
        UpdatedAmmoCountUI();
    }
}


