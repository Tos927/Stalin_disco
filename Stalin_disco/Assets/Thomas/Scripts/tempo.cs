using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempo : MonoBehaviour
{
    public bool a;
    public bool canmove;
    private SpriteRenderer spriterend;
    public Sprite sa;
    public Sprite sb;
    void Start()
    {
        spriterend = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(tempoo());
        if (canmove)
        {
            spriterend.sprite = sb;
        }
        else
        {
            spriterend.sprite = sa;
        }
        if (Input.GetKeyDown(KeyCode.Z) && canmove)
        {
            
            transform.position = new Vector3(transform.position.x , transform.position.y+1, transform.position.z);
            canmove = false;
        }
        else if (Input.GetKeyDown(KeyCode.S) && canmove)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y- 1, transform.position.z);
            canmove = false;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && canmove)
        {
            transform.position = new Vector3(transform.position.x-1, transform.position.y, transform.position.z);
            canmove = false;
        }
        else if (Input.GetKeyDown(KeyCode.D) && canmove)
        {
            transform.position = new Vector3(transform.position.x+ 1, transform.position.y , transform.position.z);
            canmove = false;
        }
    }
    IEnumerator tempoo()
    {
        Debug.Log("incouroutine");
        Debug.Log(canmove);
        if (a)
        {
            a = false;
            canmove = true;
            Debug.Log(canmove);
            
            yield return new WaitForSeconds(0.5f);
            Debug.Log(canmove);
            canmove = false;
            yield return new WaitForSeconds(0.5f);
            Debug.Log(canmove);
            canmove = false;
            a = true;
        }
        

    }
}
