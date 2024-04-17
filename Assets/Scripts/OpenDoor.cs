using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	private Vector3 vectorStart;

	private Vector3 vectorEnd;

	public GameObject slime;

	private void Start()
	{
		vectorStart = new Vector3(128f, 92f, 111f);
		vectorEnd = new Vector3(128f, 82f, 111f);
	}

	private void Update()
	{
		if (!slime)
		{
			base.transform.position = Vector3.Lerp(vectorStart, vectorEnd, Time.deltaTime / 2);
		}
	}
}
