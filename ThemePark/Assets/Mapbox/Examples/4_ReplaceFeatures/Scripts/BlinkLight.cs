<<<<<<< HEAD
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkLight : MonoBehaviour {

	float blinkDuration = 2.0f;
	void Start () {
		StartCoroutine(BlinkLed());
	}

	private IEnumerator BlinkLed()
	{
		Component halo = gameObject.GetComponent("Halo");
		while(true)
		{
			((Behaviour)halo).enabled = !((Behaviour)halo).enabled;
			yield return new WaitForSeconds(blinkDuration);
		}
	}
}
=======
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkLight : MonoBehaviour {

	float blinkDuration = 2.0f;
	void Start () {
		StartCoroutine(BlinkLed());
	}

	private IEnumerator BlinkLed()
	{
		Component halo = gameObject.GetComponent("Halo");
		while(true)
		{
			((Behaviour)halo).enabled = !((Behaviour)halo).enabled;
			yield return new WaitForSeconds(blinkDuration);
		}
	}
}
>>>>>>> 70a0f9f16ad177f4b21438af99ef17e541da6143
