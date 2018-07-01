/*
 * Name : Nishat Bhagat
 * About: This scrip manages all eight instruction screen and its content.
 * It also stores comments and notes provided by user.
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Instruction : MonoBehaviour {

	public static Instruction instance;
	public List<Button> inst_button = new List<Button>();
	// Use this for initialization
	void Start () {
		instance = this;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	Color colorwithhex = Color.green;
	public void OnEnable()
	{
		//colorwithhex = #FAD9B7FF;
		Color myColor = new Color();
		myColor = new Color32(0XFA,0XD9,0XB7,0XFF);

		if (PlayerPrefs.GetInt ("inst_1") == 1)
			inst_button [0].image.color = myColor;
		if (PlayerPrefs.GetInt ("inst_2") == 1)
			inst_button [1].image.color = myColor;
		if (PlayerPrefs.GetInt ("inst_3") == 1)
			inst_button [2].image.color = myColor;
		if (PlayerPrefs.GetInt ("inst_4") == 1)
			inst_button [3].image.color = myColor;
		if (PlayerPrefs.GetInt ("inst_5") == 1)
			inst_button [4].image.color = myColor;
		if (PlayerPrefs.GetInt ("inst_6") == 1)
			inst_button [5].image.color = myColor;
		if (PlayerPrefs.GetInt ("inst_7") == 1)
			inst_button [6].image.color = myColor;
		if (PlayerPrefs.GetInt ("inst_8") == 1)
			inst_button [7].image.color = myColor;

	}
}
