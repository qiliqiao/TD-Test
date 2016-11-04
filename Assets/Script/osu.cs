using UnityEngine;
using System.Collections;


public class osu : MonoBehaviour 
{

	public int M_number;

	[SerializeField]
	private Transform m_Player;

	private float m_X = 4.0f;
	private float m_Y = 1.0f;
	private float m_Z = 4.0f;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
	}

	public void onClick()
	{
		Debug.Log (M_number);
		Debug.Log ("Button click!");

		if (M_number == 1)
		{
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

		if (M_number == 2)
		{
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

		if (M_number == 3)
		{
			m_Player.position = new Vector3 (m_Player.position.x, m_Player.position.y + m_Y, m_Player.position.z);
		}
	}
}
