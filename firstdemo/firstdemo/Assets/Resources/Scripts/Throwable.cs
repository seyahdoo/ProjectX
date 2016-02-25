using UnityEngine;
using System.Collections;

public class Throwable : MonoBehaviour {

	void Update () {
		if(throwit)
		{
			throwit = false;
			Throw(Angle,Power);
		}
	}

	public bool throwit = false;
	public Vector2 Angle;
	public float Power;
	public void Throw(Vector2 Angle, float Power)
	{
		//Debug.Log ("throwd"+ Angle+ Power);
		this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Angle * Power);
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		StartCoroutine (Blow ());
	}

	IEnumerator Blow()
	{
		Debug.Log ("qwe");

		yield return new WaitForSeconds (1.0f);

		Camera.main.gameObject.GetComponent<SmoothFollow2D> ().Target = GameObject.FindGameObjectWithTag ("Player").transform;

		yield return true;

	}


}
