﻿using ACadSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACadSharp.Objects
{
	public class XRecrod : CadObject
	{
		public override ObjectType ObjectType => ObjectType.XRECORD;

		public override string ObjectName => DxfFileToken.TableXRecord;

		//100	Subclass marker(AcDbXrecord)

		/// <summary>
		/// Duplicate record cloning flag (determines how to merge duplicate entries)
		/// </summary>
		[DxfCodeValue(280)]
		public DictionaryCloningFlags ClonningFlags { get; set; }

		//1-369 (except 5 and 105)	These values can be used by an application in any way
		public List<Entry> Entries { get; set; } = new List<Entry>();

		public class Entry
		{
			public int Code { get; }

			public object Value { get; }

			public Entry(int code, object value)
			{
				this.Code = code;
				this.Value = value;
			}
		}
	}
}