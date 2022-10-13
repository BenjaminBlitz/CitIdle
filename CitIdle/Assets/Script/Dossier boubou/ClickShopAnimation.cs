using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickShopAnimation : MonoBehaviour
{
    public GameObject obj = null;
    public PanelOpener panel;

    private Animator movement = null;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 grow = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll = obj.GetComponent<Collider2D>();

            if (coll.OverlapPoint(grow))
            {

                /*Instantiate(gain, new Vector3(0, 0, 0), Quaternion.identity);
                gain.transform.parent = GameObject.Find("Canvas").transform;*/
            
                movement.Play("animation");
                panel.OpenPanel();
            }
        }


    }
}

