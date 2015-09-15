using UnityEngine;
using System.Collections;

public class Rotate : Pickup//inherit van pickup
{
	//override = je maakt een extensie van die functie
	public override void PlayerHit(Player _GO)
	{
		base.PlayerHit(_GO);
		
		_GO.m_score += 1;
		_GO.rotateSpeed = 100;
	}
}
