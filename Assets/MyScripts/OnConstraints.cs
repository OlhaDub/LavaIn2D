using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnConstraints : MonoBehaviour
{
    public void BeginGame()
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.None;
    }

}
