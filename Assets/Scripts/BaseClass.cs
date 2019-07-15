using UnityEngine;

namespace CommonParts
{
    public partial class BaseClass : MonoBehaviour
    {
		#region プロパティ
		public virtual Vector3 Position { get => transform.position; set => transform.position = value; }
		public virtual Quaternion Rotation { get => transform.rotation; set => transform.rotation = value; }
		public Transform Transform { get => transform; }
		#endregion

	}
}
