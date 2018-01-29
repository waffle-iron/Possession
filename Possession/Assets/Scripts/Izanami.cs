using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Izanami : MonoBehaviour
{

    public float speed = 10;
    static Izanagi s_izanagi;
    static Izanami s_izanami;

    public string form;
    public bool follow;

    public static Izanami Get()
    {
        return s_izanami;
    }

    Izanami()
    {
        s_izanami = this;
        
    }
    // Use this for initialization
    void Start()
    {
        s_izanagi = Izanagi.Get();
        form = "ghost";
        follow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!follow)
        {
            if (Input.GetAxis("NamiX") != 0)
            {
                var x = Input.GetAxis("NamiX") * Time.deltaTime * speed;
                transform.Translate(x, 0, 0);
            }
            else
            {
                this.transform.position = this.transform.position;
            }
        }
        
        if (Input.GetButton("Ybutton"))
        {
            if (Vector3.Distance(s_izanagi.transform.position, this.transform.position) < 5)
            {
                follow = true;
                if (this.form == "ghost")
                {
                    Vector3 start = new Vector3(s_izanagi.transform.transform.position.x, s_izanagi.transform.position.y, s_izanagi.transform.position.z);
                    Vector3 end = new Vector3(s_izanami.transform.transform.position.x + 1.5f, s_izanagi.transform.position.y, s_izanagi.transform.position.z);
                    s_izanagi.transform.position = Vector3.Lerp(start, end, speed * Time.deltaTime);
                }
                
                
            }
        }
         
        
    }
}
