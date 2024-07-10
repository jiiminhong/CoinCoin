using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject head;
    public GameObject cam;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    GameObject fruit;

    float cur_rot;
    float prev_rot;
    float delt_rot;

    private void Awake()
    {
        int player = PlayerPrefs.GetInt("player");
        switch (player)
        {
            case 2: fruit = player2; break;
            case 3: fruit = player3; break;
            case 4: fruit = player4; break;
            case 1: default: fruit = player1; break;
        }

        fruit.gameObject.SetActive(true);
    }

    void Start()
    {

    }

    void Update()
    {
        movement();
    }

    void movement()
    {
        Vector3 forward = transform.TransformDirection(cam.transform.forward);
        head.transform.Translate(forward * 0.3f);
        cur_rot = cam.transform.eulerAngles.y;
        delt_rot = cur_rot - prev_rot;
        prev_rot = cur_rot;

        if(delt_rot < 0 )
        {
            fruit.transform.rotation = Quaternion.Lerp(fruit.transform.rotation, Quaternion.Euler(fruit.transform.eulerAngles.x, fruit.transform.eulerAngles.y, 45), Time.deltaTime);
        } else if (delt_rot > 0)
        {
            fruit.transform.rotation = Quaternion.Lerp(fruit.transform.rotation, Quaternion.Euler(fruit.transform.eulerAngles.x, fruit.transform.eulerAngles.y, -45), Time.deltaTime);
        } else
        {
            fruit.transform.rotation = Quaternion.Lerp(fruit.transform.rotation, Quaternion.Euler(fruit.transform.eulerAngles.x, fruit.transform.eulerAngles.y, 0), Time.deltaTime);
        }
    }
}
