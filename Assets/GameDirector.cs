using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    public Transform car;
    public Transform flag;
    public TMP_Text distance;

    void Update()
    {
        float length = flag.position.x - car.position.x-1.61f;
        if (length >= 0)
        {
            distance.text = $"Distance:{length.ToString("F3")}m";
        }
        else
        {
            distance.text = "GameOver";
        }
    }
}
