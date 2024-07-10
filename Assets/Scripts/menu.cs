using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DebugUIBuilder.instance.AddButton("GAME START", StartButtonClicked);
        DebugUIBuilder.instance.AddButton("SELECT CHARACTER", SelectButtonClicked);

        DebugUIBuilder.instance.Show();
    }

    public void StartButtonClicked()
    {
        Debug.Log("Start Button Clicked");
        SceneManager.LoadScene("main");
    }

    public void SelectButtonClicked()
    {
        SceneManager.LoadScene("select");
    }
}
