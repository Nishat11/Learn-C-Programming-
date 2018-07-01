/*
 * Name : Nishat Bhagat
 * About: This scrip manage all input of main menu.
 * It provides connection between main menu and other screens.
 */
using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {

	public const string TUTORIAN_BTN = "Tutorial_btn";
	public const string PROGRAM_BTN = "Programs_btn";
	public const string QUIZ_BTN = "Quiz_btn";
	public const string SETTING_BTN = "Setting_btn";
	public const string TOPIC_BACK = "Back_btn";
	public const string CREDITS_BTN = "credit_button";
	public const string CREDITS_CLOSE_BTN = "credit_close";

	public const string INSTRUCTION_BTN = "Instruction_btn";
	public const string STRUCTURE_BTN = "Structure_btn";
	public const string VARIABLES_BTN = "Variables_btn";
	public const string INPUT_OUTPUT_BTN = "Input_output_btn";
	public const string FLOW_CONTROL_BTN = "flow_cotrol_btn";
	public const string FUNCTION_BTN = "Functions_btn";
	public const string ARRAY_BTN = "Arrays_strings_btn";
	public const string FILE_IO_BTN = "Files_operations_btn";
	public const string CONTENT_BACK_BTN = "Back_btn_details";
	public const string COMMENT_BACK_BTN = "Back_btn_comments";
	public const string SETTING_BACK_BTN = "Back_btn_setting";
	public const string QUIZ_BACK_BTN = "Back_btn_quiz";
	public const string COMMENT_BTN = "Write_comment";
	public const string BACK_BTN_PRGM = "Back_btn_program";
	public const string QUIT_YES_BTN = "quit_yes";
	public const string QUIT_NO_BTN = "quit_no";

	public GameObject quit_screen;

	public GameObject Menu_screen, List_topic_screen,List_of_topic_prgm_screen,program_screen_menu;
	public GameObject credits_screen;

	public GameObject Insturction_screen,Comment_screen;
	public GameObject Setting_screen, Quiz_screen;
	public List<GameObject> information_Screen = new List<GameObject>();
	public int selected_method_no;
	public TMP_InputField Notes;
	public int quiz_1,quiz_2,quiz_3,quiz_4;

	public List<int> prog_int = new List<int>();
	public List<int> inst_int = new List<int>();

	public static Mainmenu instance;

	public bool quit_scrn_bool = false;

	void Awake()
	{

	}

	// Use this for initialization
	void Start () {


		//PlayerPrefs.DeleteAll ();
		instance = this;
		if (!PlayerPrefs.HasKey ("notes")) {
			PlayerPrefs.SetString ("notes", "");
		} else
			Notes.text = PlayerPrefs.GetString ("notes");


		//set quiz data
		if (!PlayerPrefs.HasKey ("quiz_1")) {
			PlayerPrefs.SetInt ("quiz_1", 0);
		} else
			quiz_1 = PlayerPrefs.GetInt ("notes");
		if (!PlayerPrefs.HasKey ("quiz_2")) {
			PlayerPrefs.SetInt ("quiz_2", 0);
		} else
			quiz_2 = PlayerPrefs.GetInt ("notes");
		if (!PlayerPrefs.HasKey ("quiz_3")) {
			PlayerPrefs.SetInt ("quiz_3", 0);
		} else
			quiz_3 = PlayerPrefs.GetInt ("notes");
		if (!PlayerPrefs.HasKey ("quiz_4")) {
			PlayerPrefs.SetInt ("quiz_4", 0);
		} else
			quiz_4 = PlayerPrefs.GetInt ("quiz_4");

		//set program data
		set_prog_playerprefs("prog_1" , 0,prog_int);
		set_prog_playerprefs("prog_2" , 1,prog_int);
		set_prog_playerprefs("prog_3" , 2,prog_int);
		set_prog_playerprefs("prog_4" , 3,prog_int);
		set_prog_playerprefs("prog_5" , 4,prog_int);
		set_prog_playerprefs("prog_6" , 5,prog_int);
		set_prog_playerprefs("prog_7" , 6,prog_int);
		set_prog_playerprefs("prog_8" , 7,prog_int);

		//set instruction data
		set_prog_playerprefs("inst_1" , 0,inst_int);
		set_prog_playerprefs("inst_2" , 1,inst_int);
		set_prog_playerprefs("inst_3" , 2,inst_int);
		set_prog_playerprefs("inst_4" , 3,inst_int);
		set_prog_playerprefs("inst_5" , 4,inst_int);
		set_prog_playerprefs("inst_6" , 5,inst_int);
		set_prog_playerprefs("inst_7" , 6,inst_int);
		set_prog_playerprefs("inst_8" , 7,inst_int);

		//Advertisement.Initialize ("1552031");
	
	}

	public void set_prog_playerprefs(string key , int id, List<int> list_name)
	{
		if (!PlayerPrefs.HasKey (key)) {
			PlayerPrefs.SetInt (key, 0);
		} else
			list_name[id] = PlayerPrefs.GetInt (key);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(!quit_scrn_bool)
			{
				quit_screen.SetActive(true);
				quit_scrn_bool = true;
			}
			else
			{
				quit_screen.SetActive(false);
				quit_scrn_bool = false;
			}
		}
	
	}

	public void topic_button_clicks(GameObject topic_clicked)
	{
		switch(topic_clicked.name)
		{
		case INSTRUCTION_BTN:
			selected_method_no = 1;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_1",1);

			break;
		case STRUCTURE_BTN:
			selected_method_no = 2;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_2",1);
			break;
		case VARIABLES_BTN:
			selected_method_no = 3;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_3",1);
			break;
		case INPUT_OUTPUT_BTN:
			selected_method_no = 4;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_4",1);
			break;
		case FLOW_CONTROL_BTN:
			selected_method_no = 5;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_5",1);
			break;
		case FUNCTION_BTN:
			selected_method_no = 6;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_6",1);
			break;
		case ARRAY_BTN:
			selected_method_no = 7;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_7",1);
			break;
		case FILE_IO_BTN:
			selected_method_no = 8;
			enable_information (selected_method_no);
			PlayerPrefs.SetInt ("inst_8",1);
			break;
		case CONTENT_BACK_BTN:
			List_topic_screen.SetActive (true);
			Insturction_screen.SetActive (false);
			break;
		case COMMENT_BACK_BTN:
			Insturction_screen.SetActive (true);
			PlayerPrefs.SetString ("notes",Notes.text);
			Comment_screen.SetActive(false);

			break;
		case SETTING_BACK_BTN:
			Setting_screen.SetActive (false);
			//johny.. comment...
			if(!Quiz_screen.activeSelf)
				SceneManager.LoadScene("mainmenu");
			break;
		case QUIZ_BACK_BTN:
			Menu_screen.SetActive (true);
			Quiz_screen.SetActive (false);
			break;
		case COMMENT_BTN:
			Insturction_screen.SetActive (false);
			Comment_screen.SetActive(true);
			break;
		case BACK_BTN_PRGM:
			program_screen_menu.SetActive (false);
			List_of_topic_prgm_screen.SetActive(true);
			break;
		}
	}

	public void enable_information(int level_no)
	{
		List_topic_screen.SetActive (false);
		Insturction_screen.SetActive (true);
		for (int i = 0; i < 8; i++) {
			information_Screen [i].SetActive (false);
		}
		information_Screen [level_no - 1].SetActive (true);
	}

	public void mainmenu_btn_clicked(GameObject clicked)
	{
		switch(clicked.name)
		{
		case TUTORIAN_BTN:
			List_topic_screen.SetActive (true);
			Menu_screen.SetActive (false);
			break;
		case PROGRAM_BTN:
			Menu_screen.SetActive (false);
			List_of_topic_prgm_screen.SetActive (true);
			break;
		case QUIZ_BTN:
			Quiz_screen.SetActive (true);
			Menu_screen.SetActive (false);
			break;
		case SETTING_BTN:
			Setting_screen.SetActive (true);
			//Menu_screen.SetActive (false);
			break;
		case CREDITS_BTN:
			credits_screen.SetActive (true);
			break;

		case CREDITS_CLOSE_BTN:
			credits_screen.SetActive (false);
			break;
		case TOPIC_BACK:
			List_topic_screen.SetActive (false);
			Menu_screen.SetActive (true);
			break;

		case QUIT_YES_BTN:
			Application.Quit();
			break;

		case QUIT_NO_BTN:
			quit_screen.SetActive(false);
			quit_scrn_bool = false;
			break;

		}
	}
}
