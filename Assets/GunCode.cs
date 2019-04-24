using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCode : MonoBehaviour
{

    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject t5;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            RaycastHit hit;
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);

                if(hit.transform.name == "Target")
                {
                    Destroy(t1);
                }else if (hit.transform.name == "Target 2")
                {
                    Destroy(t2);
                }
                else if (hit.transform.name == "Target 3")
                {
                    Destroy(t3);
                }
                else if (hit.transform.name == "Target 4")
                {
                    Destroy(t4);
                }
                else if (hit.transform.name == "Target 5")
                {
                    Destroy(t5);
                }

            }
        }
        
    }
}
