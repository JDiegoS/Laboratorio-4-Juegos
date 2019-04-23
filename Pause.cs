using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public UnityEngine.UI.Text txt;
    private bool isPause = false;
    private int cont = 0;
    bool f1 = true;
    bool f2 = true;
    bool f3 = true;
    bool f4 = true;
    bool f5 = true;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //isPause = (isPause) ? Continue() : Pause();
            if (isPause)
                Continue();
            else
                Pausa();


        }
        if (GameObject.Find("Target") == null && f1 == true)
        {
            cont += 1;
            Contador();
            f1 = false;
        }
        if (GameObject.Find("Target 2") == null && f2 == true)
        {
            cont += 1;
            Contador();
            f2 = false;
        }
        if (GameObject.Find("Target 3") == null && f3 == true)
        {
            cont += 1;
            Contador();
            f3 = false;
        }
        if (GameObject.Find("Target 4") == null && f4 == true)
        {
            cont += 1;
            Contador();
            f4 = false;
        }
        if (GameObject.Find("Target 5") == null && f5 == true)
        {
            cont += 1;
            Contador();
            f5 = false;
        }
        if (cont == 5)
        {
            Victory();
        }

    }
    public void Pausa()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        transform.Find("PauseMenu").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPause = true;

        


    }
    public void Continue()
    {
        transform.Find("PauseMenu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPause = false;
    }
    public void Contador()
    {
        txt.text = "Targets Hit: " + cont;
    }
    public void Victory()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0.0f;
        transform.Find("Victory").gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Other();
        }


    }
    public void Restart()
    {

        SceneManager.LoadScene("Targets");
    }
    public void Other()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("Objects");
        Cursor.visible = true;
    }
}
