using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click : MonoBehaviour, IPointerClickHandler
{
    const float SCALE = 1.2f;
    const float SCALE_BACK = 5.0f / 6.0f;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        int prev = -1;
        GameObject prevObject = null;
        prev = PlayerPrefs.GetInt("player");
        switch (prev)
        {
            case 1: prevObject = GameObject.FindGameObjectWithTag("player1"); break;
            case 2: prevObject = GameObject.FindGameObjectWithTag("player2"); break;
            case 3: prevObject = GameObject.FindGameObjectWithTag("player3"); break;
            case 4: prevObject = GameObject.FindGameObjectWithTag("player4"); break;
            default: prevObject = null; break;
        }

        if (prevObject != null)
        {
            prevObject.transform.localScale = new Vector3(SCALE_BACK, SCALE_BACK, SCALE_BACK);
        }

        if (gameObject.tag == "player1") PlayerPrefs.SetInt("player", 1);
        else if (gameObject.tag == "player2") PlayerPrefs.SetInt("player", 2);
        else if (gameObject.tag == "player3") PlayerPrefs.SetInt("player", 3);
        else if (gameObject.tag == "player4") PlayerPrefs.SetInt("player", 4);

        gameObject.transform.localScale = new Vector3(SCALE, SCALE, SCALE);
    }
}
