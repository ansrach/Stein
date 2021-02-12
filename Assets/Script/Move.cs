using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
   


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move1();       
    }

    void Move1()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // รับค่าจากการเคลื่อนที่ของแกนนั้นๆ Horizontal = แกนนอน
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime; // Vertical = แนวตั้ง
        Vector3 move = new Vector3(h, 0f, v);
        rb.AddForce(move, ForceMode.Acceleration); // เพิ่มแรงให้ตัว player
    }

}
