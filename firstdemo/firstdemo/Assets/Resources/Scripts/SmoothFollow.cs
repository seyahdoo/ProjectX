using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {

	public Transform Target;
	public float cameraSmoothSpeed = 0.1f;

	// Update is called once per frame
	//Bu kodu kullanmıyorum. Top büyüdükçe kamera kutunun dışına çıkmasın diye yazdıydım. Beceremedim. Neyse kısmet değilmiş.
	void Update () {
		//GetComponent<Transform>().position = whereCameraShouldBe.GetComponent <Transform>().position -new Vector3(0, -3, -10);
		transform.position = Vector3.Lerp (transform.position, Target.position, cameraSmoothSpeed);
		transform.rotation = Quaternion.Slerp (transform.rotation, Target.rotation, cameraSmoothSpeed);
	}
}
