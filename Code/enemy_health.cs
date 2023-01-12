using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemy_health : MonoBehaviour
{
    public GameObject c_leftArm;
    public GameObject c_rightArm;
    public int healthNum;
    public int damageNum;
    public GameObject character;
    public bool isHit = false;
    public Text GameOver;
    public bool playerDied = false;


    void Start()
    {
        print("Player health: " + healthNum);
        GameOver.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(healthNum < 0)
        {
            Destroy(this.gameObject);
            playerDied = true;
            GameOver.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == c_leftArm)
        {
            isHit = true;
            print("Damage: " + healthNum);
            healthNum -= damageNum;
        }

        if(other.gameObject == c_rightArm)
        {
            isHit = true;
            print("Damage: " + healthNum);
            healthNum -= damageNum;
        }
    }
}
