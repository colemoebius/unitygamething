using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {


	void OnTriggerEnter(Collider collider) 
	{

		
		CoinController.coinCount++;
			Destroy(this.gameObject);

			

		}
	
	
	



}
