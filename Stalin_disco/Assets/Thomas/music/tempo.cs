using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempo : MonoBehaviour
{
    public GameObject arg;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(tempoo());
        if (a)
        {
            
        }
        else
        {
            
        }
    }
    IEnumerator tempoo()
    {

        if (a)
        {
            a = false;
            yield return new WaitForSeconds(0.5f);
            //arg.SetActive(false);
            arg.transform.position = new Vector3(+0, +1, +0);
            yield return new WaitForSeconds(0.5f);
            arg.transform.position = new Vector3(+0, -1, +0);
            //arg.SetActive(true);
            a = true;
        }
        

    }
}
