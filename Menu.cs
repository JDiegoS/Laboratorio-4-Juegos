using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public UnityEngine.UI.Text txt;
    private bool isPause = false;
 


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

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
        

    }
    public void Pausa()
    {
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


    
    public void Restart()
    {

        SceneManager.LoadScene("Objects");
    }
    public void Other()
    {
        SceneManager.LoadScene("Targets");
    }
}
