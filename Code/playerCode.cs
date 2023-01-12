using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerCode : MonoBehaviour
{
    public GameObject enemy_left;
    public GameObject enemy_right;
    public int damageN = 1;
    public int p_health = 5;
    public GameObject player;
    public bool playerWin = false;
    public Text Victory;


    void Start()
    {
        Victory.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(p_health < 0)
        {
            Destroy(this.gameObject);
            Victory.gameObject.SetActive(true);
            playerWin = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject == enemy_left || col.gameObject == enemy_right)
        {
            print("You've taken damage! " + p_health);
            p_health -= damageN;
        }
    }
}
