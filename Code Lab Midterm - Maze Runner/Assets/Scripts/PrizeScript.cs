using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //score goes up by 1
        GameManager.instance.score++;
    }
}
