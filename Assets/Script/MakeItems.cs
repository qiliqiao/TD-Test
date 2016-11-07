using UnityEngine;
using System.Collections;

public class MakeItems : MonoBehaviour 
{
	[SerializeField]
	private Transform m_Player;

	[SerializeField]
	private GameObject m_GamePrefab;

	private int m_Time;
	private bool m_Pausing;


	void Start () 
	{
		
	}


	void Update ()
	{
		m_Pausing = GameObject.Find("Player").GetComponent<GameOver>().pausing;

		if (m_Pausing == false) 
		{
			m_Time++;
			if (m_Time >= 60) 
			{
				transform.position = new Vector3 (transform.position.x, m_Player.position.y + 50, transform.position.z);

				GameObject Go = Instantiate (m_GamePrefab, transform.position, Quaternion.identity) as GameObject;
				m_Time = 0;
			}
		}
	}
}
