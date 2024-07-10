using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    float time;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("ChangeSceneResult", 10.0f);
        // ChangeSceneResult();
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time > 10f)
        {
            ChangeSceneResult();
        }
    }

    public void ChangeSceneResult()
    {
        // yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("result");
    }
}

// https://sylvester127.tistory.com/2
// https://a-game-developer0724.tistory.com/40