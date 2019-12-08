using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    public InputField nameField;
    public GameObject popupPanel;
    public Text messageText;

    // Start is called before the first frame update
    void Start()
    {
	hidePopupPanel ();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void hidePopupPanel(){
        popupPanel.SetActive (false);
    }

    public void showPopupPanel(){
        popupPanel.SetActive (true);
    }

    public void sayHello(){
	messageText.text = "Hello " + nameField.text + "!";
	showPopupPanel ();
    }
}
