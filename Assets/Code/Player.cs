using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public float speed = 1;
	public float rotateSpeed = 0;
    public float m_score = 0;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
		this.transform.position += Vector3.right * Time.deltaTime * speed;
		this.transform.Rotate(Vector3.back * Time.deltaTime * rotateSpeed);
    }
}
