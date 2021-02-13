using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public timer tim;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(2);
        }
        if (collision.gameObject.tag == "Player2")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(3);
        }
        if (collision.gameObject.tag == "Player3")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(4);
        }
        if (collision.gameObject.tag == "Player4")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(5);
        }
        if (collision.gameObject.tag == "Player5")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(6);
        }
        if (collision.gameObject.tag == "Player6")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(7);
        }
        if (collision.gameObject.tag == "Player7")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(8);
        }
        if (collision.gameObject.tag == "Player8")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(9);
        }
        if (collision.gameObject.tag == "Player9")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(10);
        }
        if (collision.gameObject.tag == "Player10")
        {
            tim.scene1();
            SceneManager.LoadSceneAsync(11);
        }
    }
}
