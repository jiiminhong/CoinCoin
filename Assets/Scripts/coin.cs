using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public AudioClip getSnd;
    public GameObject scores;
    private Score text;
    

    // Start is called before the first frame update
    void Start()
    {
        scores = GameObject.Find("ScoreBox");
        text = scores.GetComponent<Score>();
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(getCoin());
    }

    IEnumerator getCoin()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(getSnd);
        yield return new WaitForSeconds(1.0f);
        //scores.SetText();
        Debug.Log(scores);
        text.GetScore();
        Destroy(this.gameObject);
    }
}
