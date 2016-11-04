using UnityEngine;
using System.Collections;

public class MakeItems : MonoBehaviour 
{
	[SerializeField]
	private Transform m_Player;

	[SerializeField]
	private GameObject m_GamePrefab;

	private int m_Time;


	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update ()
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
