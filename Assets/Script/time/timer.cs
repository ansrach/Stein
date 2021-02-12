using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] float time_c = 30; //ใส่เพื่อให้สามารถกำหนดที่ยูนิตี้ได้
    float time_Max;
    static int number = 1;
    public Text timer_text;    
    
    void Update()
    {
        timer_text.text = "Time: " + time_Max; //อยากได้เป็นเลขตัวเดียว

        time_c -= Time.deltaTime; // ให้เวลาลดที่ละ1
        time_Max = Mathf.Floor(time_c); //ปัดเศษลง
        if (time_c <= 0)
        {
            SceneManager.LoadSceneAsync(number);
        }
        
    }
    public void scene1()
    {
        number  += 1;
    }


}
