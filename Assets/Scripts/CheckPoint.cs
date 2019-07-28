using CommonParts;
using UnityEngine;


enum MoveMode
{
	Straight = 0,
	Curve,
}

public class CheckPoint : BaseClass
{
	public GameObject[] Nexts;

	MoveMode Mode;

}

