using UnityEngine;

namespace CommonParts
{
	public partial class BaseClass
	{
		#region フィールド
		private double hp;
		#endregion

		#region プロパティ
		public double HP { get => hp; set => hp = value; }
		#endregion
	}
}