/*
 * Name : Nishat Bhagat
 * About: This scrip shows all eight program and also its qusetion. 
 * It manages all question for each level and also check its value.
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Manage_program : MonoBehaviour {

	public const string PROGRAM_1_BTN = "Program1_btn";
	public const string PROGRAM_2_BTN = "Program2_btn";
	public const string PROGRAM_3_BTN = "Program3_btn";
	public const string PROGRAM_4_BTN = "Program4_btn";
	public const string PROGRAM_5_BTN = "Program5_btn";
	public const string PROGRAM_6_BTN = "Program6_btn";
	public const string PROGRAM_7_BTN = "Program7_btn";
	public const string PROGRAM_8_BTN = "Program8_btn";
	public const string RUN_BTN = "Check_prgm";
	public const string WARNING_OK_BTN = "warning_ok";
	public const string ERROR_OK_BTN = "Error_ok";
	public static Manage_program instance;


	public const string BACK_BTN_PRGM = "Back_btn_program";
	public const string BACK_MAIN_PRGM_SCREEN = "Back_btn";

	public int Selected_level_no;
	public List<Button> prog_button = new List<Button>();
	public GameObject success_msg;

	public GameObject List_of_topics_prgm_screen,program_mainscreen,Main_menu_screen;
	public GameObject Wrong_answer_screen, Warning_screen;
	//List of program screen
	public List<GameObject> Programs_screen = new List<GameObject>();
	public List<GameObject> Output_screen = new List<GameObject>();
	public List<Dropdown> answer_dropdown = new List<Dropdown>();
	public List<int> correct_answers = new List<int>();
	// Use this for initialization
	void Start () {
		Selected_level_no = 0;
		instance = this;
	}
	public void OnEnable()
	{
		if (PlayerPrefs.GetInt ("prog_1") == 1)
			prog_button [0].interactable = false;
		if (PlayerPrefs.GetInt ("prog_2") == 1)
			prog_button [1].interactable = false;
		if (PlayerPrefs.GetInt ("prog_3") == 1)
			prog_button [2].interactable = false;
		if (PlayerPrefs.GetInt ("prog_4") == 1)
			prog_button [3].interactable = false;
		if (PlayerPrefs.GetInt ("prog_5") == 1)
			prog_button [4].interactable = false;
		if (PlayerPrefs.GetInt ("prog_6") == 1)
			prog_button [5].interactable = false;
		if (PlayerPrefs.GetInt ("prog_7") == 1)
			prog_button [6].interactable = false;
		if (PlayerPrefs.GetInt ("prog_8") == 1)
			prog_button [7].interactable = false;
		
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void normal_btn_clicked(GameObject btn_clicked)
	{
		switch(btn_clicked.name)
		{
		case RUN_BTN:
			check_answer (Selected_level_no);
			break;
		case WARNING_OK_BTN:
			Warning_screen.SetActive (false);
			break;
		case ERROR_OK_BTN:
			Wrong_answer_screen.SetActive (false);
			answer_dropdown [Selected_level_no - 1].value = 0;
			break;
		case BACK_BTN_PRGM:
			program_mainscreen.SetActive (false);

			break;
		case BACK_MAIN_PRGM_SCREEN:
			Main_menu_screen.SetActive (true);
			this.gameObject.SetActive (false);
			break;
		}
	}


	//Starts new program
	public void program_btn_clicked(GameObject prg_clicked)
	{
		for (int i = 0; i < 8; i++) {
			Programs_screen [i].SetActive (false);
		}
		success_msg.SetActive (false);
		switch(prg_clicked.name)
		{

		case PROGRAM_1_BTN:
			Programs_screen [0].SetActive (true);
			program_mainscreen.SetActive (true);
			Selected_level_no = 1;
			break;
		case PROGRAM_2_BTN:
			program_mainscreen.SetActive (true);
			Programs_screen [1].SetActive (true);
			Selected_level_no = 2;
			break;
		case PROGRAM_3_BTN:
			program_mainscreen.SetActive (true);
			Programs_screen [2].SetActive (true);
			Selected_level_no = 3;
			break;
		case PROGRAM_4_BTN:
			program_mainscreen.SetActive (true);
			Programs_screen [3].SetActive (true);
			Selected_level_no = 4;
			break;
		case PROGRAM_5_BTN:
			program_mainscreen.SetActive (true);
			Programs_screen [4].SetActive (true);
			Selected_level_no = 5;
			break;
		case PROGRAM_6_BTN:
			program_mainscreen.SetActive (true);
			Programs_screen [5].SetActive (true);
			Selected_level_no = 6;
			break;
		case PROGRAM_7_BTN:
			program_mainscreen.SetActive (true);
			Programs_screen [6].SetActive (true);
			Selected_level_no = 7;
			break;
		case PROGRAM_8_BTN:
			program_mainscreen.SetActive (true);
			Programs_screen [7].SetActive (true);
			Selected_level_no = 8;
			break;
		}
		this.gameObject.SetActive(false);
	}


	public void check_answer(int level_no)
	{
		if (answer_dropdown [level_no - 1].value == correct_answers [level_no - 1]) 
		{
			success_msg.SetActive (true);
			Output_screen [level_no - 1].SetActive (true);
			switch(Selected_level_no)
			{
			case 1:
				PlayerPrefs.SetInt ("prog_1",1);
				break;
			case 2:
				PlayerPrefs.SetInt ("prog_2",1);
				break;
			case 3:
				PlayerPrefs.SetInt ("prog_3",1);
				break;
			case 4:
				PlayerPrefs.SetInt ("prog_4",1);
				break;
			case 5:
				PlayerPrefs.SetInt ("prog_5",1);
				break;
			case 6:
				PlayerPrefs.SetInt ("prog_6",1);
				break;
			case 7:
				PlayerPrefs.SetInt ("prog_7",1);
				break;
			case 8:
				PlayerPrefs.SetInt ("prog_8",1);
				break;
			}
		} 
		else if (answer_dropdown [level_no - 1].value == 0) 
		{
			Warning_screen.SetActive (true);
		} 
		else 
		{
			Wrong_answer_screen.SetActive (true);
		}
			
	}
		
}
