using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	[SerializeField]
	private Transform m_Player;

	[SerializeField]
	private Text m_Text;

	private float m_Score;

	private int m_ToInt;

	// Use this for initialization
	void Start () 
	{
		m_Score = 0;
		m_Text.text = "Score:0";
	}
	
	// Update is called once per frame
	void Update () 
	{
		m_Score = m_Player.position.y - 1;
		m_Text.text = "Score:" + ((int)m_Score).ToString ();
	}
}
