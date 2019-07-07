using UnityEngine;

namespace CommonParts
{
    public class BaseClass : MonoBehaviour
    {
		#region フィールド
		private double dblHP;
		#endregion

		#region プロパティ
		public virtual double HP { get => dblHP; set => dblHP = value; }
		public virtual Vector3 Position { get => transform.position; set => transform.position = value; }
		public virtual Quaternion Rotation { get => transform.rotation; set => transform.rotation = value; }
		public Transform Transform { get => transform; }
		#endregion

	}
}
