using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InfoPopup : MonoBehaviour {

    string btnName;
    public GameObject panel1, panel2, panel3, panel4;
    public GameObject menutxt1, menutxt2, menutxt3;

    void setPopupActive(int i)
    {
        switch (i)
        {
            case 0:
                panel1.SetActive(false);
                panel2.SetActive(false);
                panel3.SetActive(false);
                panel4.SetActive(false);
                break;
            case 1:
                panel1.SetActive(true);
                panel2.SetActive(false);
                panel3.SetActive(false);
                panel4.SetActive(false);
                break;
            case 2:
                panel1.SetActive(false);
                panel2.SetActive(true);
                panel3.SetActive(false);
                panel4.SetActive(false);
                break;
            case 3:
                panel1.SetActive(false);
                panel2.SetActive(false);
                panel3.SetActive(true);
                panel4.SetActive(false);
                break;
            case 4:
                panel1.SetActive(false);
                panel2.SetActive(false);
                panel3.SetActive(false);
                panel4.SetActive(true);
                break;
            default:
                break;
        }
    }

    void selectMenu(int i)
    {
        switch (i)
        {
            case 1:
                SceneManager.LoadScene("main");
                break;
            case 2:
                SceneManager.LoadScene("sidedishes");
                break;
            case 3:
                SceneManager.LoadScene("drinks");
                break;
            default:
                break;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                btnName = hit.transform.name;
                switch (btnName)
                {
                    case "Food1":
                        setPopupActive(1);
                        break;
                    case "Food2":
                        setPopupActive(2);
                        break;
                    case "Food3":
                        setPopupActive(3);
                        break;
                    case "Food4":
                        setPopupActive(4);
                        break;
                    case "Menu1":
                        selectMenu(1);
                        break;
                    case "Menu2":
                        selectMenu(2);
                        break;
                    case "Menu3":
                        selectMenu(3);
                        break;
                    default:
                        setPopupActive(0);
                        break;
                }
            }
            else
            {
                setPopupActive(0);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Left mouse clicked!");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log(hit.transform.name);
                btnName = hit.transform.name;
                switch (btnName)
                {
                    case "Food1":
                        setPopupActive(1);
                        break;
                    case "Food2":
                        setPopupActive(2);
                        break;
                    case "Food3":
                        setPopupActive(3);
                        break;
                    case "Food4":
                        setPopupActive(4);
                        break;
                    case "Menu1":
                        selectMenu(1);
                        break;
                    case "Menu2":
                        selectMenu(2);
                        break;
                    case "Menu3":
                        selectMenu(3);
                        break;
                    default:
                        setPopupActive(0);
                        break;
                }
            }
            else
            {
                setPopupActive(0);
            }
        }
    }
}
