using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testHealthCode : MonoBehaviour
{
    public int healthNum = 10;
    public int damageNum = 1;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject bag;
    public GameObject player;
    public bool playerWin = false;
    public Text Victory;

    void Start()
    {
        print(healthNum);
        Victory.gameObject.SetActive(false);
    }

    void Update()
    {
        if(healthNum <= 0)
        {
            Destroy(this.gameObject);
            Victory.gameObject.SetActive(true);
            playerWin = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnCollisionEnter(Collision collision)
    {

        //print("collision!");
        if (collision.gameObject == leftHand)
        {
            //print("damage");
            print("Damage done: " + healthNum);
            healthNum -= damageNum;
        }

        if (collision.gameObject == rightHand)
        {
            //print("damage");
            print("Damage done: " + healthNum);
            healthNum -= damageNum;
        }
    }
}
