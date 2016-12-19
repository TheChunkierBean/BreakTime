using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimation : MonoBehaviour 
{

	public Animator anim;

	void Update()
	{
		if (Input.GetButtonDown("Fire1")) 
		{
			anim = GetComponent<Animator>();
			anim.SetBool ("Shoot", true);
		} 
	}
		

}
