using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    public GameObject Ball;
    public Sprite[] balls; 
    public GameObject menuBall;
    private int currentBallIndex = 0;
    public void ChangeBall(bool change)
    {
        int newIndex;
        if (change) { newIndex = (currentBallIndex+1) % balls.Length;}
        else { newIndex = (currentBallIndex-1)*2 % balls.Length;}
        if (newIndex >= 0 && newIndex < balls.Length)
        { 
            currentBallIndex = newIndex;
            Ball.GetComponent<SpriteRenderer>().sprite = balls[currentBallIndex];
            menuBall.GetComponent<Image>().sprite = balls[currentBallIndex];
        }
    }
}

