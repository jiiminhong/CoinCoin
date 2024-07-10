using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class select : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DebugUIBuilder.instance.AddLabel("SELECT CHARACTER");
        DebugUIBuilder.instance.AddButton("PLAY GAME", ButtonClicked);

        DebugUIBuilder.instance.Show();
    }

    public void ButtonClicked()
    {
        SceneManager.LoadScene("main");
    }
}
