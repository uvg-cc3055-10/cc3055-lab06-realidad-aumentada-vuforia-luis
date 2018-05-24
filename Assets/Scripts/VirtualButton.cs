using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

    public Animator birdAnim;
    private VirtualButtonBehaviour virtualBtn;
    
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {//Funcion para que el pajaro cante al precionar el boton
        birdAnim.SetTrigger("sing");
        Debug.Log("si funciona");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        //Codigo para iniciar el boton virtual
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
