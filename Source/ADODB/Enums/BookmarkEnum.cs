﻿using System;
using NetOffice;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByVersion ADODB 2.1, 2.5
	 /// </summary>
	[SupportByVersionAttribute("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum BookmarkEnum
	{
		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("ADODB", 2.1,2.5)]
		 adBookmarkCurrent = 0,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("ADODB", 2.1,2.5)]
		 adBookmarkFirst = 1,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("ADODB", 2.1,2.5)]
		 adBookmarkLast = 2
	}
}