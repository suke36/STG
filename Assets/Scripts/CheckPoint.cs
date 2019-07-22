using CommonParts;

namespace Check
{
	enum MoveMode
	{
		Straight = 0,
		Curve,
	}
	
	public class CheckPoint : BaseClass
	{
		CheckPoint next;

		MoveMode Mode;

		public CheckPoint Next { get => next; set => next = value; }
	}
}
