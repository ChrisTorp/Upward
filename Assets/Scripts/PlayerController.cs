using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool facingRight = true;

	private Animator anim;

	[Header("Player..")]
	public bool isAlive = false;
	public bool isGrounded = false;
	public bool isKneeling = false;
	public float isRunning = 0;

	public bool canMove = true;

	[Header("Current Player")]
	public currentplayer currentPlayer;

	void Awake () {
		anim = GetComponentInChildren<Animator> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		isRunning = Input.GetAxis ("Horizontal");
		Jump ();
		Kneel ();
		anim.SetFloat ("isRunning", Mathf.Abs(isRunning));
		anim.SetBool ("isKneeling", isKneeling);
	}

	void FixedUpdate() {
		if (canMove) {
			Move ();
		}
	}

	[System.Serializable]
	public class currentplayer {
		public int playerID;
		public float playerSpeed;
		public float jumpForce;
		public Color playerEyesColor;
		public Color playerBodyColor;
		public Color playerSpeedoColor;
	}
		
	public void Move() {
		float moveFaster = 0;
		if (isRunning > 0.5)
			moveFaster = 1;
		else if (isRunning < -0.5)
			moveFaster = -1;
		GetComponent<Rigidbody2D> ().AddForce (new Vector2(moveFaster * currentPlayer.playerSpeed, GetComponent<Rigidbody2D>().velocity.y));

		if (moveFaster == 0)
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
		if (isRunning > 0 && !facingRight)
			Flip ();
		else if (isRunning < 0 && facingRight)
			Flip ();

		/*if (GetComponent<Rigidbody2D> ().velocity.x > 0.5f && moveFaster == 0) {
			GetComponent<Rigidbody2D> ().isKinematic = true;
			GetComponent<Rigidbody2D> ().isKinematic = false;
		}*/
	}
	public void Jump() {
		if (Input.GetButtonDown("Jump"))
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * currentPlayer.jumpForce);
	}

	public void Kneel() {
		if (Input.GetAxis ("Vertical") < -0.05) {
			canMove = false;
			isKneeling = true;
		} else {
			canMove = true;
			isKneeling = false;
		}
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
