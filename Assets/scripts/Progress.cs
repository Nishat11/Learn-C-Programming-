/*
 * Name : Nishat Bhagat
 * About: This scrip has references for all input buttons of progress scrin.
 * It trackes playes progress and also update it.
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class Progress : MonoBehaviour {

	public List<GameObject> c_images = new List<GameObject> ();
	public const string CLEAR_PROG_BTN = "reset";
	public const string YES_BTN = "Yes";
	public const string NO_BTN = "No";
	public Slider progressbar;
	public GameObject warnig_clear_screen;

	public GameObject reset_buttton;
	public Text Quize_value, program_Value;
	public int quize_value_int, Program_Value_int;
	public List<Button> prog_button_quiz = new List<Button>();
	public List<Button> inst_button_quiz = new List<Button>();
	public List<GameObject> Output_screen_quiz = new List<GameObject>();

	public List<Button> Quiz_btns = new List<Button>();

	// Use this for initialization
	void Start () {
	
	}


	void check_quiz_progress()
	{
		quize_value_int = 0;

		if (PlayerPrefs.GetInt ("quiz_1") == 1) {
			c_images [0].SetActive (true);
			quize_value_int++;
		}
		if (PlayerPrefs.GetInt ("quiz_2") == 1) {
			c_images [1].SetActive (true);
			quize_value_int++;
		}
		if (PlayerPrefs.GetInt ("quiz_3") == 1) {
			c_images [2].SetActive (true);
			quize_value_int++;
		}
		if (PlayerPrefs.GetInt ("quiz_4") == 1) {
			c_images [3].SetActive (true);
			quize_value_int++;
		}
		Quize_value.text = quize_value_int.ToString ();
	}
	void check_program_progress()
	{
		Program_Value_int = 0;
		if (PlayerPrefs.GetInt ("prog_1") == 1)
			Program_Value_int++;
		if (PlayerPrefs.GetInt ("prog_2") == 1)
			Program_Value_int++;
		if (PlayerPrefs.GetInt ("prog_3") == 1)
			Program_Value_int++;
		if (PlayerPrefs.GetInt ("prog_4") == 1)
			Program_Value_int++;
		if (PlayerPrefs.GetInt ("prog_5") == 1)
			Program_Value_int++;
		if (PlayerPrefs.GetInt ("prog_6") == 1)
			Program_Value_int++;
		if (PlayerPrefs.GetInt ("prog_7") == 1)
			Program_Value_int++;
		if (PlayerPrefs.GetInt ("prog_8") == 1)
			Program_Value_int++;

		progressbar.value= Program_Value_int;
		program_Value.text = Program_Value_int.ToString();
		
	}
	void OnEnable()
	{
		check_quiz_progress ();
		check_program_progress ();
		if (Mainmenu.instance.Quiz_screen.activeSelf)
			reset_buttton.SetActive (false);
		else
			reset_buttton.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
	
	}

	void clear_all_data()
	{
		//reset quiz data
		PlayerPrefs.SetInt ("quiz_1", 0);
		PlayerPrefs.SetInt ("quiz_2", 0);
		PlayerPrefs.SetInt ("quiz_3", 0);
		PlayerPrefs.SetInt ("quiz_4", 0);

		//reset program data
		PlayerPrefs.SetInt ("prog_1", 0);
		PlayerPrefs.SetInt ("prog_2", 0);
		PlayerPrefs.SetInt ("prog_3", 0);
		PlayerPrefs.SetInt ("prog_4", 0);
		PlayerPrefs.SetInt ("prog_5", 0);
		PlayerPrefs.SetInt ("prog_6", 0);
		PlayerPrefs.SetInt ("prog_7", 0);
		PlayerPrefs.SetInt ("prog_8", 0);

		//reset instruction data
		PlayerPrefs.SetInt ("inst_1", 0);
		PlayerPrefs.SetInt ("inst_2", 0);
		PlayerPrefs.SetInt ("inst_3", 0);
		PlayerPrefs.SetInt ("inst_4", 0);
		PlayerPrefs.SetInt ("inst_5", 0);
		PlayerPrefs.SetInt ("inst_6", 0);
		PlayerPrefs.SetInt ("inst_7", 0);
		PlayerPrefs.SetInt ("inst_8", 0);

		PlayerPrefs.SetString ("notes","");

	}
	public void prgress_btn_clicked(GameObject prg_clicked)
	{
		switch(prg_clicked.name)
		{
		case CLEAR_PROG_BTN:
			
			warnig_clear_screen.SetActive (true);
			break;
		case YES_BTN:
			clear_all_data ();
			progressbar.value = 0;
			for (int i = 0; i < 4; i++)
			{
				c_images [i].SetActive (false);
				Quiz_btns[i].interactable = true;
			}
			for (int i = 0; i < 8; i++) {
//				Mainmenu.instance.List_topic_screen.SetActive(true);
//				Mainmenu.instance.List_of_topic_prgm_screen.SetActive(true);
//				Mainmenu.instance.Quiz_screen.SetActive(true);

				//Mainmenu.instance.List_topic_screen.SetActive(false);
				//Mainmenu.instance.List_of_topic_prgm_screen.SetActive(false);
				//Mainmenu.instance.Quiz_screen.SetActive(false);

				prog_button_quiz [i].interactable = true;
				inst_button_quiz [i].image.color = Color.white;
				Output_screen_quiz [i].SetActive (false);

			}
			warnig_clear_screen.SetActive (false);
			break;
		case NO_BTN:
			warnig_clear_screen.SetActive (false);
			break;
		}
	}
}
