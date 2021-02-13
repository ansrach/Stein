using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset10 : MonoBehaviour
{
    public void Reset100()
    {
        SceneManager.LoadSceneAsync(10);
    }
}
