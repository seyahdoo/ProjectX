using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public bool IsMyTurn = true;

	public float PowerMultiplier = 10;

	public Vector3 FirstMousePos;
	public Vector3 LastMousePos;

	public GameObject ThrowablePrefab;

	void Start()
	{
		if (ThrowablePrefab == null) 
		{		
			ThrowablePrefab = Resources.Load ("Prefabs/ThrowablePrefab") as GameObject;
		}

	}


	IEnumerable UseTurn()
	{
		//wait for pull

		//send pull

		//send a bulllet

		//wait for collision

		//send healt to server
		yield return new WaitForSeconds(1);

	}


	void OnMouseDown()
	{
		Debug.Log ("asd");
		if (IsMyTurn) 
		{
			FirstMousePos = Input.mousePosition;
		}

	}

	void OnMouseDrag()
	{
		//draw a arrow

	}

	void OnMouseUp()
	{
		LastMousePos = Input.mousePosition;
		var dist = LastMousePos - FirstMousePos;

		//this.gameObject.GetComponent<Throwable> ().Throw (dist, PowerMultiplier);

		var toThrow = Instantiate<GameObject> (ThrowablePrefab);
		toThrow.GetComponent<Throwable> ().Throw (dist, PowerMultiplier);
		toThrow.transform.position = this.transform.position;

		Camera.main.GetComponent<SmoothFollow2D> ().Target = toThrow.transform;

	}


}
