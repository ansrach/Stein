using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    
    void Update()
    {
        CoinRotate();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            Destroy(this.gameObject); // เมื่อชนเหรียญแล้วจะหายไป
        }
    }

     void CoinRotate()
    {
        this.transform.Rotate(0f, 50f * Time.deltaTime, 0f); // ทำให้เหรียญหมุนตามแกน y
    }
}
