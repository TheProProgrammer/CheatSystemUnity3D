using UnityEngine;

public class CheatSys : MonoBehaviour
{
	string cheatBuffer;
	char currentChar;
	string[] cheats = {""};//Cheats Are Case Sensitive

	void Update()
	{
		if (Input.anyKeyDown)
		{
			currentChar = Input.inputString.ToCharArray()[0];
			cheatBuffer = cheatBuffer + currentChar;

			for (int i = 0; i < cheats.Length ; i++)
			{
				if (cheatBuffer == cheats[i])
				{
                    print("A Cheat Was Registered");

                    /*switch (cheatString)      Edit This Part According To Your Need
                    {
                        case "Cheat1":
                            SomeFunction();
                            break;
            
                        case "Cheat2":
                            SomeFunction2();
                            break;

                                        case "Cheat2":
                            SomeFunction2();
                            break;
                    }*/
                }
                else if (cheats [i].StartsWith (cheatBuffer))
				{
                    break;
				}
				else if (cheats[i].StartsWith(cheatBuffer) == false && i == cheats.Length-1)
				{
					cheatBuffer = "";
				} 
			}
		}
	}
}
