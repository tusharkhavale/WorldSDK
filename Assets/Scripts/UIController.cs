using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	private MainController mainController;

	private Text txtCurrLat;
	private Text txtCurrLong;

	private InputField inputLat;
	private InputField inputLong;

	private Button btnLoad;

	private double latitude;
	private double longitude;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start()
	{
		LoadReferences ();
		AddButtonListners ();
	}


	/// <summary>
	/// Loads the references.
	/// </summary>
	private void LoadReferences()
	{
		mainController = MainController.GetInstance ();
		Transform startPage = transform.Find ("StartPage");
		txtCurrLat = startPage.Find ("CurrentLocation").Find ("txtLatValues").GetComponent<Text> ();
		txtCurrLong = startPage.Find ("CurrentLocation").Find ("txtLongValues").GetComponent<Text> ();

		inputLat = startPage.Find ("GoTo").Find ("inputLatitude").GetComponent<InputField> (); 
		inputLong = startPage.Find ("GoTo").Find ("inputLongitude").GetComponent<InputField> (); 

		btnLoad = startPage.Find ("GoTo").Find ("btnGo").GetComponent<Button> ();
	}

	/// <summary>
	/// Adds the button listners.
	/// </summary>
	private void AddButtonListners()
	{
		btnLoad.onClick.AddListener (this.OnClickLoad);
	}


	/// <summary>
	/// Raises the click load event.
	/// </summary>
	private void OnClickLoad()
	{
		latitude = double.Parse(inputLat.text);
		longitude = double.Parse(inputLong.text);

		mainController.LoadMap (latitude, longitude);
	}

	/// <summary>
	/// Sets the current location display.
	/// </summary>
	/// <param name="latitude">Latitude.</param>
	/// <param name="longitude">Longitude.</param>
	public void SetCurrentLocation(float latitude, float longitude)
	{
		txtCurrLat.text =  ""+latitude;
		txtCurrLong.text = ""+longitude;
	}
}
