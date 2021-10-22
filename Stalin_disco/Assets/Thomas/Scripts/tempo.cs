using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempo : MonoBehaviour
{
    public bool a;
    public bool canmove;
    private SpriteRenderer spriterend;
    private SpriteRenderer heartspriterend;
    public Sprite sa;
    public Sprite sb;

    public GameObject heart; 
    public Sprite heartdown;
    public Sprite heartup;
    void Start()
    {
        spriterend = GetComponent<SpriteRenderer>();
        heartspriterend = heart.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(tempoo());
        if (canmove)
        {
            heartspriterend.sprite = heartup;
            spriterend.sprite = sb;
        }
        else
        {
            heartspriterend.sprite = heartdown;
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
