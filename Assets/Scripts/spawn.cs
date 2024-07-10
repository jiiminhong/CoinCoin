using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCoin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnCoin()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f);

            Vector3 pos = spawnPoint.transform.position + new Vector3(Random.Range(-1, 1), Random.Range(0, 0), Random.Range(-1, 1));
            Instantiate(coin, pos, Quaternion.identity);
        }
    }
}
