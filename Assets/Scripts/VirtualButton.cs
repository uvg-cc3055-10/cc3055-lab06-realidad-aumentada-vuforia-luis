using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

    public Animator birdAnim;
    private VirtualButtonBehaviour virtualBtn;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        birdAnim.SetTrigger("sing");
        Debug.Log("si funciona");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
