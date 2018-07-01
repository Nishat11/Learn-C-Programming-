/*
 * Name : Nishat Bhagat
 * About: This scrip defines all variable for quize and also shows random question based on selected quize number*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Manage_quiz : MonoBehaviour {


	public List <string> level_1_questions = new List<string>();
	public List <string> level_2_questions = new List<string>();
	public List <string> level_3_questions = new List<string>();
	public List <GameObject> level_4_questions = new List<GameObject>();

	public List <string> correct_answers_level_1 = new List<string>();
	public List <string> correct_answers_level_2 = new List<string>();
	public List <string> correct_answers_level_3 = new List<string>();
	public List <string> correct_answers_level_4 = new List<string>();



	public List <Text> questions = new List<Text>();

	public List <Text> que_1_options = new List<Text>();
	public List <Text> que_2_options = new List<Text>();
	public List <Text> que_3_options = new List<Text>();
	int que_1,que_2,que_3,que_4,que_5,que_6,que_7,que_8;

	public GameObject quiz_fail, quiz_done;

	public level_answer[] options;
	public level_answer[] options_que_2;
	public level_answer[] options_que_3;
	public level_answer[] options_que_4;
	public static Manage_quiz instance;

	public bool quest_1,quest_2,quest_3;

	public GameObject Level_1_screell_view, level_4_scroll_view;
	public GameObject hint_screen;
	//public Text [][] answers = new Text();
	public const string SUBMIT_BTN = "Submit";
	public const string HINT_BTN = "Hint";
	public const string BACK_QUIZ_BTN = "Back_btn_quiz_menu";
	public const string QUIZ_DONE_BNT = "quiz_done_ok";
	public const string QUIZ_FAIL_BTN = "quiz_fail_ok";

	public GameObject quiz_menu;

	// Use this for initialization
	void Start () {
		instance = this;
		quest_1 = quest_2 = quest_3 = false;
	}


	// Update is called once per frame
	void Update () {
	
	}

	public void quiz_ques_clicked(GameObject btn_clicked)
	{
		switch (btn_clicked.name) {
		case SUBMIT_BTN:
			submit();
			break;
		case HINT_BTN:
			hint_screen.SetActive(true);
			break;
		case BACK_QUIZ_BTN:
			this.gameObject.SetActive(false);
			Level_1_screell_view.SetActive (false);
			level_4_scroll_view.SetActive(false);
			quest_1 = quest_2 = quest_3 = false;
			quiz_menu.SetActive(true);
			break;
		case QUIZ_DONE_BNT:
			quiz_done.SetActive(false);
			Level_1_screell_view.SetActive (false);
			level_4_scroll_view.SetActive(false);
			quest_1 = quest_2 = quest_3 = false;
			this.gameObject.SetActive(false);
			quiz_menu.SetActive(true);
			break;
		case QUIZ_FAIL_BTN:
			quiz_fail.SetActive(false);
			break;
		}
	}

	public void submit()
	{
		if (quest_1 == true && quest_2 == true && quest_3 == true) {
			quiz_done.SetActive (true);
			start_quiz.instance.success_msg.text = start_quiz.instance.success_message[start_quiz.instance.quiz_no-1];
			switch(start_quiz.instance.quiz_no)
			{
			case 1:
				PlayerPrefs.SetInt ("quiz_1", 1);
				break;
			case 2:
				PlayerPrefs.SetInt ("quiz_2", 1);
				break;
			case 3:
				PlayerPrefs.SetInt ("quiz_3", 1);
				break;
			case 4:
				PlayerPrefs.SetInt ("quiz_4", 1);
				break;
			}
		}
		else
			quiz_fail.SetActive (true);
	}
	//first question
	public void level1_answer_index(Text id)
	{
		switch (start_quiz.instance.quiz_no) {
		
		case 1:
			if(id.text == correct_answers_level_1[que_1])
				quest_1 = true;
			else
				quest_1 = false;
			break;
		case 2:
			if(id.text == correct_answers_level_2[que_3])
				quest_1 = true;
			else
				quest_1 = false;
			break;
		case 3:
			if(id.text == correct_answers_level_3[que_5])
				quest_1 = true;
			else
				quest_1 = false;
			break;
		case 4:
			if(id.text == correct_answers_level_4[que_7])
				quest_1 = true;
			else
				quest_1 = false;
			//Debug.Log("asne3;;"+correct_answers_level_4[que_7]);
			break;
		}

		Debug.Log ("id"+id);

		//return true;
		//if()
	}
	//second question
	public void level2_answer_index(Text id)
	{
		switch (start_quiz.instance.quiz_no) {
			
		case 1:
			if(id.text == correct_answers_level_1[2])
				quest_2 = true;
			else
				quest_2 = false;
			break;
		case 2:
			if(id.text == correct_answers_level_2[2])
				quest_2 = true;
			else
				quest_2 = false;
			break;
		case 3:
			if(id.text == correct_answers_level_3[2])
				quest_2 = true;
			else
				quest_2 = false;
			break;
		case 4:
			if(id.text == correct_answers_level_4[2])
				quest_2 = true;
			else
				quest_2 = false;
			//Debug.Log("asne3;;"+correct_answers_level_4[2]);
			break;
		}
	}
	//third question
	public void level3_answer_index(Text id)
	{
		switch (start_quiz.instance.quiz_no) {
			
		case 1:
			if(id.text == correct_answers_level_1[que_2])
				quest_3 = true;
			else
				quest_3 = false;
			break;
		case 2:
			if(id.text == correct_answers_level_2[que_4])
				quest_3 = true;
			else
				quest_3 = false;
			break;
		case 3:
			if(id.text == correct_answers_level_3[que_6])
				quest_3 = true;
			else
				quest_3 = false;
			break;
		case 4:
			if(id.text == correct_answers_level_4[que_8])
				quest_3 = true;
			else
				quest_3 = false;

			//Debug.Log("asne3;;"+correct_answers_level_4[que_8]);
			break;
		}
	}
	public void leves_answer_index(Text id)
	{

	}

	public void set_level1()
	{
		que_1 = Random.Range(0,2);
		questions [0].text = "1. "+ level_1_questions [que_1];
		questions [1].text = "2. "+level_1_questions [2];
		que_2 = Random.Range(3,5);
		questions [2].text = "3. "+level_1_questions [que_2];
		for (int i=0; i<4; i++) {
			que_1_options[i].text = options[que_1].array[i];
			que_2_options[i].text = options[2].array[i];
			que_3_options[i].text = options[que_2].array[i];
		}
	}

	public void set_level2()
	{
		que_3 = Random.Range(0,2);
		questions [0].text = "1. "+ level_2_questions [que_3];
		questions [1].text = "2. "+level_2_questions [2];
		que_4 = Random.Range(3,5);
		questions [2].text = "3. "+level_2_questions [que_4];
		for (int i=0; i<4; i++) {
			que_1_options[i].text = options_que_2[que_3].array[i];
			que_2_options[i].text = options_que_2[2].array[i];
			que_3_options[i].text = options_que_2[que_4].array[i];
		}
	}
	public void set_level3()
	{
		que_5 = Random.Range(0,2);
		questions [0].text = "1. "+ level_3_questions [que_5];
		questions [1].text = "2. "+level_3_questions [2];
		que_6 = Random.Range(3,5);
		questions [2].text = "3. "+level_3_questions [que_6];
		for (int i=0; i<4; i++) {
			que_1_options[i].text = options_que_3[que_5].array[i];
			que_2_options[i].text = options_que_3[2].array[i];
			que_3_options[i].text = options_que_3[que_6].array[i];
		}
	}
	public void set_level4()
	{
		for (int i = 0; i<5; i++) {
			level_4_questions[i].SetActive(false);
		}
		que_7 = Random.Range(0,2);
		level_4_questions [que_7].SetActive (true);
		level_4_questions [2].SetActive (true);
		que_8 = Random.Range(3,5);
		level_4_questions [que_8].SetActive (true);
	}
}
[System.Serializable]
public class level_answer
{
	public string[] array;
}
