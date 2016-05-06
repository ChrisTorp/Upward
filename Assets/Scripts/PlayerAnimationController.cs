using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour {

	private PlayerController playerController;

	[Header("Parts")]
	public GameObject Body;
	public GameObject Eyes;
	public GameObject Arms;
	public GameObject Legs;
	public GameObject Speedo;
	public GameObject Hoodie;
	public GameObject HoodieArms;

	[Header("Scripts")]
	public ChangeColor BodyColor;
	public ChangeColor EyesColor;
	public ChangeColor ArmsColor;
	public ChangeColor LegsColor;
	public ChangeColor SpeedoColor;

	[Header("Animators")]
	public Animator BodyAnimator;
	public Animator EyesAnimator;
	public Animator ArmsAnimator;
	public Animator LegsAnimator;
	public Animator SpeedoAnimator;
	public Animator HoodieAnimator;
	public Animator HoodieArmsAnimator;

	void Awake () {
		playerController = GetComponent<PlayerController> ();

		BodyColor = Body.GetComponent<ChangeColor> ();
		EyesColor = Eyes.GetComponent<ChangeColor> ();
		ArmsColor = Arms.GetComponent<ChangeColor> ();
		LegsColor = Legs.GetComponent<ChangeColor> ();
		SpeedoColor = Speedo.GetComponent<ChangeColor> ();

		BodyAnimator = Body.GetComponent<Animator> ();
		EyesAnimator = Eyes.GetComponent<Animator> ();
		ArmsAnimator = Arms.GetComponent<Animator> ();
		LegsAnimator = Legs.GetComponent<Animator> ();
		SpeedoAnimator = Speedo.GetComponent<Animator> ();
		HoodieAnimator = Hoodie.GetComponent<Animator> ();
		HoodieArmsAnimator = HoodieArms.GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Body
		if (Body.gameObject.activeInHierarchy) {
			BodyAnimator.SetBool ("isAlive", playerController.isAlive);
			BodyAnimator.SetBool ("isGrounded", playerController.isAlive);
			BodyAnimator.SetFloat ("isRunning", Mathf.Abs (playerController.isRunning));
			BodyColor.color = playerController.currentPlayer.playerBodyColor;
		}

		//Arms
		if (Arms.gameObject.activeInHierarchy) {
			ArmsAnimator.SetBool ("isAlive", playerController.isAlive);
			ArmsAnimator.SetBool ("isGrounded", playerController.isAlive);
			ArmsAnimator.SetFloat ("isRunning", Mathf.Abs (playerController.isRunning));
			ArmsColor.color = playerController.currentPlayer.playerBodyColor;
		}

		//Legs
		if (Legs.gameObject.activeInHierarchy) {
			LegsAnimator.SetBool ("isAlive", playerController.isAlive);
			LegsAnimator.SetBool ("isGrounded", playerController.isAlive);
			LegsAnimator.SetFloat ("isRunning", Mathf.Abs (playerController.isRunning));
			LegsColor.color = playerController.currentPlayer.playerBodyColor;
		}

		//Eyes
		if (Eyes.gameObject.activeInHierarchy) {
			EyesAnimator.SetBool ("isAlive", playerController.isAlive);
			EyesAnimator.SetBool ("isGrounded", playerController.isAlive);
			EyesAnimator.SetFloat ("isRunning", Mathf.Abs (playerController.isRunning));
			EyesColor.color = playerController.currentPlayer.playerEyesColor;
		}

		//Speedo
		if (Speedo.gameObject.activeInHierarchy) {
			SpeedoAnimator.SetBool ("isAlive", playerController.isAlive);
			SpeedoAnimator.SetBool ("isGrounded", playerController.isAlive);
			SpeedoAnimator.SetFloat ("isRunning", Mathf.Abs (playerController.isRunning));
			SpeedoColor.color = playerController.currentPlayer.playerSpeedoColor;
		}

		//Hoodie
		if (Hoodie.gameObject.activeInHierarchy) {
			HoodieAnimator.SetBool ("isAlive", playerController.isAlive);
			HoodieAnimator.SetBool ("isGrounded", playerController.isAlive);
			HoodieAnimator.SetFloat ("isRunning", Mathf.Abs (playerController.isRunning));
		}

		//Hoodie Arms
		if (HoodieArms.gameObject.activeInHierarchy) {
			HoodieArmsAnimator.SetBool ("isAlive", playerController.isAlive);
			HoodieArmsAnimator.SetBool ("isGrounded", playerController.isAlive);
			HoodieArmsAnimator.SetFloat ("isRunning", Mathf.Abs (playerController.isRunning));
		}
	}
}
