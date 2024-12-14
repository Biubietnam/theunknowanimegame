using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000348 RID: 840
	public static class DailyActiveInfoNotifyReflection
	{
		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x00069C5F File Offset: 0x00067E5F
		public static FileDescriptor Descriptor
		{
			get
			{
				return DailyActiveInfoNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000F48 RID: 3912
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtEYWlseUFjdGl2ZUluZm9Ob3RpZnkucHJvdG8aF0RhaWx5QWN0aXZpdHlJ",
			"bmZvLnByb3RvIowBChVEYWlseUFjdGl2ZUluZm9Ob3RpZnkSGgoSZGFpbHlf",
			"YWN0aXZlX3BvaW50GAkgASgNEjMKF2RhaWx5X2FjdGl2ZV9sZXZlbF9saXN0",
			"GAwgAygLMhIuRGFpbHlBY3Rpdml0eUluZm8SIgoaZGFpbHlfYWN0aXZlX3F1",
			"ZXN0X2lkX2xpc3QYAiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			DailyActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DailyActiveInfoNotify), DailyActiveInfoNotify.Parser, new string[]
			{
				"DailyActivePoint",
				"DailyActiveLevelList",
				"DailyActiveQuestIdList"
			}, null, null, null, null)
		}));
	}
}
