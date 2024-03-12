using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Vector3 moveVector;
    public int changesAmount;
    private Vector3 positionChange;
    private int currentChangeCounter;
    // Start is called before the first frame update
    void Start()
    {
        positionChange.x = moveVector.x / changesAmount;
        positionChange.y = moveVector.y / changesAmount;
        ResetcurrentChangeCounter();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentChangeCounter < 0)
        {
            transform.position += positionChange;
            currentChangeCounter++;
        }
        else if (currentChangeCounter == changesAmount)
        {
            ResetcurrentChangeCounter();
        }
        else
        {
            transform.position -= positionChange;
            currentChangeCounter++;
        }
    }
    void ResetcurrentChangeCounter()
    {
        currentChangeCounter = -changesAmount;
    }
}
