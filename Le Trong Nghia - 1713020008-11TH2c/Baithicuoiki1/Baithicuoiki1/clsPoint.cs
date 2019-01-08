/*
 * Created by SharpDevelop.
 * User: C1-A02
 * Date: 1/8/2019
 * Time: 11:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Baithicuoiki1
{
	/// <summary>
	/// Description of clsPoint.
	/// </summary>
	public class clsPoint
	{
		int ix, iy;
		public int X
		{
			get
			{
				return ix;
			}
			set
			{
				ix = value;
			}
		}
		public int Y
		{
			get
			{
				return iy;
			}
			set
			{
				iy = value;
			}
		}
		public clsPoint()
		{
			X=0;
			Y=0;
		}
		public clsPoint(int a, int b)
		{
			X = a;
			Y = b;
		}
	}
}
