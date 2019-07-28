using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonParts;

public class ScrollManager : BaseClass
{
	/// <summary>
	/// このnextを追っていく
	/// 追いついたらnextのnext(lol)
	/// </summary>
	GameObject next;

	/// <summary>
	/// 次のチェックポイントまでの到達時間
	/// </summary>
	public float ScrollSpeed;



	void Update()
	{
		// 追従対象オブジェクトのTransformから、目的地を算出
		Vector3 targetPos = next.GetComponent<CheckPoint>().Position;
		Quaternion targetRot = next.GetComponent<CheckPoint>().Rotation;

		//ref
		Vector3 velocity = Vector3.zero;
		float fvelocity = 0;
		// 移動
		Position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, ScrollSpeed);

		//回転
		Quaternion rot = new Quaternion();
		rot.x = Mathf.SmoothDampAngle(Rotation.x, targetRot.x, ref fvelocity, ScrollSpeed);
		rot.y = Mathf.SmoothDampAngle(Rotation.y, targetRot.y, ref fvelocity, ScrollSpeed);
		rot.z = Mathf.SmoothDampAngle(Rotation.z, targetRot.z, ref fvelocity, ScrollSpeed);
		Rotation = rot;

	}
}
