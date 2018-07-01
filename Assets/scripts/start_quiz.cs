/*
 *Name : Nishat Bhagat
 *About: This scrip manages input part of quize level.
 * It has infomation for all available option for each question and it tarcks selected option for each question.
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class start_quiz : MonoBehaviour {

	public static start_quiz instance;
	public const string QUIZ_1_BUTTON = "Quiz_1";
	public const string QUIZ_2_BUTTON = "Quiz_2";
	public const string QUIZ_3_BUTTON = "Quiz_3";
	public const string QUIZ_4_BUTTON = "Quiz_4";
	public const string SHOW_PROGRESS_BTN = "show_progress";

	public int quiz_no =0;
	public List<string> Quiz_name = new List<string> ();
	public List<string> success_message = new List<string>();
	//public List<int> a 
	public Text heading, success_msg;
	public List<Button> quiz_buttons = new List<Button>();

	public GameObject question_screen,progress_screen;

	// Use this for initialization
	void Start () {
		instance = this;
	}

	void OnEnable()
	{
		if (PlayerPrefs.GetInt ("quiz_1") == 1)
			quiz_buttons [0].interactable = false;
		if (PlayerPrefs.GetInt ("quiz_2") == 1)
			quiz_buttons [1].interactable = false;
		if (PlayerPrefs.GetInt ("quiz_3") == 1)
			quiz_buttons [2].interactable = false;
		if (PlayerPrefs.GetInt ("quiz_4") == 1)
			quiz_buttons [3].interactable = false;

	}

	// Update is called once per frame
	void Update () {
	
	}
	public IEnumerator level_1_start(float waittime)
	{
		yield return new WaitForSeconds (waittime);
		Manage_quiz.instance.set_level1();
		Manage_quiz.instance.Level_1_screell_view.SetActive (true);
		this.gameObject.SetActive(false);
	}
	public IEnumerator level_2_start(float waittime)
	{
		yield return new WaitForSeconds (waittime);
		Manage_quiz.instance.set_level2();
		Manage_quiz.instance.Level_1_screell_view.SetActive (true);
		this.gameObject.SetActive(false);
	}
	public IEnumerator level_3_start(float waittime)
	{
		yield return new WaitForSeconds (waittime);
		Manage_quiz.instance.set_level3();
		Manage_quiz.instance.Level_1_screell_view.SetActive (true);
		this.gameObject.SetActive(false);
	}

	public IEnumerator level_4_start(float waittime)
	{
		yield return new WaitForSeconds (waittime);
		Manage_quiz.instance.set_level4();
		Manage_quiz.instance.level_4_scroll_view.SetActive (true);
		this.gameObject.SetActive(false);
	}


	public void quiz_button_clicked(GameObject btn_clicked)
	{
		switch (btn_clicked.name) {
		case QUIZ_1_BUTTON:
			question_screen.SetActive(true);
			StartCoroutine(level_1_start(0.1f));
			quiz_no = 1;
			heading.text = Quiz_name[0];
			break;
		case QUIZ_2_BUTTON:
			question_screen.SetActive(true);
			StartCoroutine(level_2_start(0.1f));
			quiz_no = 2;
			heading.text = Quiz_name[1];
			//this.gameObject.SetActive(false);
			break;
		case QUIZ_3_BUTTON:
			question_screen.SetActive(true);
			StartCoroutine(level_3_start(0.1f));
			quiz_no = 3;
			heading.text = Quiz_name[2];
			//this.gameObject.SetActive(false);
			break;
		case QUIZ_4_BUTTON:
			question_screen.SetActive(true);
			StartCoroutine(level_4_start(0.1f));
			quiz_no = 4;
			heading.text = Quiz_name[3];
			//this.gameObject.SetActive(false);
			break;
		case SHOW_PROGRESS_BTN:
			progress_screen.SetActive(true);
			break;
		}
	}
}
