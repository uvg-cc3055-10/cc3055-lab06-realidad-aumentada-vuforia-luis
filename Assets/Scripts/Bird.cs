using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Animator anim;
    AudioSource audios;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        audios = GetComponent<AudioSource>();
	}

    //Funcion para resetear la animacion 
    void ResetHopInt()
    {
        anim.SetInteger("hop", 0);
    }
    //Funcion para hacer que el pajaro cante
    void PlaySong()
    {
        audios.Play();
    }

}
