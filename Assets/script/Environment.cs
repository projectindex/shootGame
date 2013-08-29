using UnityEngine;
using System.Collections;

public class Environment{

	static float Yup=35.5f;
	static float Ydown=3.5f;
	static float Xleft=-5.5f;
	static float Xrigth=39.7f;
	public static bool outScene(Vector3 pos)
	{
		if(pos.x<Xleft||pos.x>Xrigth||pos.y>Yup||pos.y<Ydown)
			return true;
		else return false;
	}
	public static Vector3 checkedPos(Vector3 pos)
	{
		if(pos.x<Xleft) pos.x=Xleft;
		else if(pos.x>Xrigth) pos.x=Xrigth;
		if(pos.y<Ydown) pos.y=Ydown;
		else if(pos.y>Yup) pos.y=Yup;
		return pos;
	}
}
