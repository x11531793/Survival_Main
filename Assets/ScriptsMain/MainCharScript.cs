using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharScript : MonoBehaviour {

    public Animator myAnimator;

	// Use this for initialization
	void Start () {

        myAnimator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        myAnimator.SetFloat("VSpeed", Input.GetAxis("Vertical"));
		
	}
}
