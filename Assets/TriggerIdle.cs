using UnityEngine;
using System.Collections;

public class TriggerIdle : MonoBehaviour 
{

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		StartCoroutine(MyCoroutine());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator MyCoroutine2()
	{
		//This is a coroutine
		//DoSomething();
		
		yield return new WaitForSeconds (2.0f);    //Wait one frame
		
		idle();
	}

	IEnumerator MyCoroutine()
	{
		//This is a coroutine
		//DoSomething();
		
		yield return new WaitForSeconds (2.5f);    //Wait one frame
		
		idle();
	}
	
	public void idle(){
		anim.SetInteger("AnimState", 0);
	}

	public void Talking()
	{
		anim.SetInteger("AnimState", 2);
		MyCoroutine2();

	
	}

}

