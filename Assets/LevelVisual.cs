namespace NultBolts
{
	using System;
	using TMPro;
	using UnityEngine;

	public class LevelVisual : MonoBehaviour
	{
		public TextMeshProUGUI level0,level1,level2,level3;

		void OnEnable()
		{
			level0.SetText((DataManager.indexLevel_NB+1).ToString());
			level1.SetText((DataManager.indexLevel_NB+2).ToString());
			level2.SetText((DataManager.indexLevel_NB+3).ToString());
			level3.SetText((DataManager.indexLevel_NB+4).ToString());
		}
	}
}
