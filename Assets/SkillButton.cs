using TMPro;
using UnityEngine;
using UnityEngine.UI;

public static class SkillCounter
{
	public static int GetCount(int skillID) { return PlayerPrefs.GetInt($"SkillCount{skillID}",1); }
	public static void AddCount(int skillID,int add)
	{
		var count=GetCount(skillID)+add;

		if(count<0)
		{
			count=0;
		}

		PlayerPrefs.SetInt($"SkillCount{skillID}",count);
	}
}

public class SkillButton : MonoBehaviour
{
	public int skillID;

	private Button  button;
	TextMeshProUGUI countTMP;

	int count;

	void Start()
	{
		button=GetComponent<Button>();
		button.onClick.AddListener(OnClickButton);

		countTMP=GetComponentInChildren<TextMeshProUGUI>();



		count        =SkillCounter.GetCount(skillID);
		countTMP.text=count.ToString();
	}
	void OnClickButton()
	{
		if(count>0)
		{
			count--;

			switch (skillID)
			{
				case 0:
					break;
				case 1:
					break;
				case 2:
					break;
			}

			countTMP.text=count.ToString();

			SkillCounter.AddCount(skillID,-1);
		}
	}
}
