using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Start0()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
