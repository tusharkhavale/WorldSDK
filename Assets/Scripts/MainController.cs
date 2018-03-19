using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wrld;

public class MainController : MonoBehaviour {

	private static MainController instance;
	public WrldMap wrldMap;
	public UIController uiController;


	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake()
	{
		instance = this;
	}

	/// <summary>
	/// Gets the instance.
	/// </summary>
	/// <returns>The instance.</returns>
	public static MainController GetInstance()
	{
		if (instance != null) 
		{
			return instance;
		}
		return null;
	}

	/// <summary>
	/// Loads the map.
	/// </summary>
	/// <param name="latitude">Latitude.</param>
	/// <param name="longitude">Longitude.</param>
	public void LoadMap(double latitude, double longitude)
	{
		wrldMap.m_latitudeDegrees = latitude;
		wrldMap.m_longitudeDegrees = longitude;
		wrldMap.gameObject.SetActive (true);
	}


	public void SetCurrentLocation(float latitude, float longitude)
	{
		uiController.SetCurrentLocation (latitude, longitude);
	}

}
