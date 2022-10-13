using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCarAnimation : MonoBehaviour
{
    public GameObject obj = null;
    public GameObject gain = null; 

    private Animator movement = null;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 grow = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll = obj.GetComponent<Collider2D>();

            if(coll.OverlapPoint(grow))
            {

                /*Instantiate(gain, new Vector3(0, 0, 0), Quaternion.identity);
                gain.transform.parent = GameObject.Find("Canvas").transform;*/
                var newObj = GameObject.Instantiate(gain);
                newObj.transform.parent = GameObject.Find("Canvas").transform;
                newObj.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
                Object.Destroy(newObj, 0.5f);

                movement.Play("animation");
                Object.Destroy(obj, 0.15f);
            }
        }

        
    }
}
