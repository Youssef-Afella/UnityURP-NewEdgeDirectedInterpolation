using UnityEngine;
using System.Collections;

namespace UnityEngine.Rendering.Toon.Universal.Samples
{
	public class Rotator : MonoBehaviour
	{

		public Vector3 rotate = Vector3.zero;

		void Update()
		{
			transform.Rotate(rotate * Time.deltaTime);
		}
	}
}

