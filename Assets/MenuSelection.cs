using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelection : MonoBehaviour {

    public Color selected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        GetComponentInChildren<Transform>().localScale = new Vector3(1.2f, 1.2f, 1);
        //GetComponentInChildren<TextMesh>().color = new Color(1, 0, 0, 1);
    }

    private void OnMouseExit()
    {
        GetComponentInChildren<Transform>().localScale = new Vector3(1, 1, 1);
        //GetComponentInChildren<TextMesh>().color = new Color(255, 165, 0, 255);
    }

    private void OnMouseDown()
    {
        //Debug.Log("Mouse clicked on a menu!");
        //GetComponentInChildren<Transform>().localScale = new Vector3(1.2f, 1.2f, 1);
        GetComponentInChildren<TextMesh>().color = selected;
    }
}
