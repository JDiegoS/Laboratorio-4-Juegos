using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public Material mat;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetButton("Fire1"))
        {
           
            if(Physics.Raycast(ray, out hit))
                {
                
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * 50f);

                }
            }
 
        }

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "Caja")
            {
                t1.GetComponent<Renderer>().material = mat;
            }
            else if (hit.transform.name == "Caja 1")
            {
                t2.GetComponent<Renderer>().material = mat;
            }
            else if (hit.transform.name == "Caja 2")
            {
                t3.GetComponent<Renderer>().material = mat;
            }
        }


}
}
