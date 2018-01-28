using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzanagiScript : MonoBehaviour {

    public float speed = 10;
    public float sec = 10f;
    private float timer;

    // Use this for initialization
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        //if (timer > sec)
        //{
        //    var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //    transform.Translate(x, 0, 0);
        //}
    }
}
