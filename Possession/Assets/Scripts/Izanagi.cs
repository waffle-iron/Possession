using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Izanagi : MonoBehaviour {

    public float speed = 10;
    static Izanagi s_izanagi;
    static Izanami s_izanami;

    public bool follow;

    public static Izanagi Get()
    {
        return s_izanagi;
    }

    Izanagi()
    {
        s_izanagi = this;
    }
    // Use this for initialization
    void Start () {
        s_izanami = Izanami.Get();
        follow = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!follow)
        {
            var x = Input.GetAxis("NagiX") * Time.deltaTime * speed;
            transform.Translate(x, 0, 0);
        } else
        {
            var x = Input.GetAxis("NamiX") * Time.deltaTime * speed;
            transform.Translate(x, 0, 0);
        }
        
    }
}
