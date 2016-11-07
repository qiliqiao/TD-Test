using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
	[SerializeField]
	private Transform m_Player;

	[SerializeField]
	private Transform m_Floor;

	[SerializeField]
	private float m_Speed;

	private float m_X = 4.0f;
	//private float m_Y = 1.0f;
	private float m_Z = 4.0f;

	[SerializeField]
	private Slider m_Slider;

	void OnCollisionEnter(Collision collision)
	{	
		if (collision.transform.tag == "Stone") 
		{
			m_Slider.value -= 0.1f;
		}

		if (collision.transform.tag == "battery") 
		{
			m_Slider.value += 0.1f;
		}
	}


	void Start () 
	{
		m_Slider = GameObject.Find("Slider").GetComponent<Slider>();
		m_Slider.value = 1.0f;
	}

	void Update ()
	{
		m_Slider.value -= 0.00084f;
		if (m_Slider.value == 0.0f) 
		{
			m_Speed = 0.0f;
		}
		m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y + m_Speed, m_Player.position.z);

		if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			Debug.Log ("左");
			if (m_Player.position.x == -11) 
			{
				if (m_Player.position.z <= 1) 
				{
					m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y, m_Player.position.z + m_Z);
				}
			}
			else
			{
				if (m_Player.position.x >= -11)
				{
					m_Player.position = new Vector3 (m_Player.position.x - m_X, m_Player.position.y, m_Player.position.z);
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			Debug.Log ("右");
			if (m_Player.position.z == -11) 
			{
				if (m_Player.position.x <= 1) 
				{
					m_Player.position = new Vector3 (m_Player.position.x + m_X, m_Player.position.y, m_Player.position.z);
				}
			}
			else
			{
				if (m_Player.position.z >= -11)
				{
					m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y, m_Player.position.z - m_Z);
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			Debug.Log ("上");

			//m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y + m_Y, m_Player.position.z);
		}
	}
}