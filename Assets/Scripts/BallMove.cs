using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public bool startPlay;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {   
        startPlay=true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPos;
        if (startPlay){
            rb.velocity = new Vector3(0,0,0);
            myPos=new Vector3(0,0.2f,0);
            this.transform.position = myPos;
            rb.AddForce(20,0,0,ForceMode.Impulse);
            startPlay=false;
            Debug.Log(startPlay);
        }
        else if (transform.position.x>20 | transform.position.x<-20)
        {
            startPlay=true;
            Debug.Log(startPlay);
        }
    }
}
