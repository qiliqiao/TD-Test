using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlCameraScript : MonoBehaviour 
{
    [SerializeField]
	private Transform m_Camera;

	[SerializeField]
	private Transform m_Player;

	void Start () 
    {
	}
	
	void Update () 
    {
		m_Camera.position = new Vector3 (m_Camera.position.x, m_Player.position.y + 26, m_Camera.position.z);


		#if UNITY_EDITOR_WIN
		float x = 10 * Input.GetAxis("Mouse X"); 
		float y = -10 * Input.GetAxis("Mouse Y");

		m_Camera.transform.Rotate(y, x, 0);

		float z = m_Camera.transform.eulerAngles.z;

		m_Camera.transform.Rotate(0, 0, -z);
		#endif




	}
}
