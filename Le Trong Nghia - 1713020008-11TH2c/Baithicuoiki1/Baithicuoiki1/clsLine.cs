﻿/*
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
	/// Description of clsLine.
	/// </summary>
	public class clsLine : clsHinh
	{
		public clsLine()
		{
		}
		public clsLine(clsPoint d1, clsPoint d2)
		{
			D1 = d1;
			D2 = d2;
		}
		public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen p)
		{
			g.DrawLine(p,D1.X,D1.Y,D2.X,D2.Y);
		}
	}
}