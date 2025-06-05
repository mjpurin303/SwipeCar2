using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    public GameObject title;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;
            this.speed = swipeLength / 500f;
            GetComponent<AudioSource>().Play();
            title.SetActive(false);
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
        
    }
}
