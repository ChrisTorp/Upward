using UnityEngine;
using System.Collections;

namespace Functions {

	public class Convert {

		public static bool ConvertIntToBool (int i) {
			bool value = false;
			if (i == 0)
				value = false;
			else if (i == 1)
				value = true;

			return value;
		}

		public static int ConvertBoolToInt (bool i) {
			int value = 0;
			if (i)
				value = 1;
			else if (!i)
				value = 0;

			return value;
		}

	}

}
