using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.5f, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.5f, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.5f, 0, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.5f, 0, 0);
        }

        float speedx = Mathf.Abs(this.transform.localScale.x);

        this.animator.speed =  speedx /2.0f;

    }
}
