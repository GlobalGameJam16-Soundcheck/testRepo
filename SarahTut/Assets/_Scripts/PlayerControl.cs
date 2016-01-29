using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float bruu = Input.GetAxis ("Horizontal");
//		rb.AddForce(new Vector3 (10 * bruu, 0f, 0f));
//		transform.position += new Vector3 (bruu, 0f, 0f);
		transform.Translate (new Vector3 (bruu, 0f, 0f));
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("Wall")) {
			Debug.Log ("coll");
			rb.maxAngularVelocity = 0f;
			rb.velocity = Vector3.zero;
		}
	}
}
