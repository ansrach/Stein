using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombBehave : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {       
        if (collision.gameObject.tag == "Player3")
        {
            SceneManager.LoadSceneAsync(3);
        }
        if (collision.gameObject.tag == "Player4")
        {
            SceneManager.LoadSceneAsync(4);
        }
        if (collision.gameObject.tag == "Player5")
        {
            SceneManager.LoadSceneAsync(5);
        }
        if (collision.gameObject.tag == "Player6")
        {
            SceneManager.LoadSceneAsync(6);
        }
        if (collision.gameObject.tag == "Player7")
        {
            SceneManager.LoadSceneAsync(7);
        }
        if (collision.gameObject.tag == "Player8")
        {
            SceneManager.LoadSceneAsync(8);
        }
        if (collision.gameObject.tag == "Player10")
        {
            SceneManager.LoadSceneAsync(10);
        }
        if (collision.gameObject.tag == "Block")
        {
            Destroy(this.gameObject);
        }

    }

}
