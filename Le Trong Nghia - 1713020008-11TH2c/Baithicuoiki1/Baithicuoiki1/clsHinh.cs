/*
 * Created by SharpDevelop.
 * User: C1-A02
 * Date: 1/8/2019
 * Time: 11:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Baithicuoiki1
{
	/// <summary>
	/// Description of clsHinh.
	/// </summary>
	public class clsHinh
	{
		clsPoint d1, d2;
		public clsPoint D1
		{
			get
			{
				return d1;
			}
			set
			{
				d1.X = value.X;
				d1.Y = value.Y;
			}
		}
		public clsPoint D2
		{
			get
			{
				return d2;
			}
			set
			{
				d2.X = value.X;
				d2.Y = value.Y;
			}
		}
		public clsHinh()
		{
			d1 = new clsPoint();
			d2 = new clsPoint();
		}
		public virtual void Draw(Graphics g, Pen p)
		{
		}
	}
}
