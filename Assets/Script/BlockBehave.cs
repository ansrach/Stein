using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehave : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "Bomb")
        {
            Destroy(this.gameObject);
        }
    }
}
