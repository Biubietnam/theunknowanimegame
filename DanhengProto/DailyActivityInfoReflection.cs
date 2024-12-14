using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200034A RID: 842
	public static class DailyActivityInfoReflection
	{
		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x0006A08F File Offset: 0x0006828F
		public static FileDescriptor Descriptor
		{
			get
			{
				return DailyActivityInfoReflection.descriptor;
			}
		}

		// Token: 0x04000F53 RID: 3923
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEYWlseUFjdGl2aXR5SW5mby5wcm90byJpChFEYWlseUFjdGl2aXR5SW5m" + "bxITCgt3b3JsZF9sZXZlbBgPIAEoDRIaChJkYWlseV9hY3RpdmVfcG9pbnQY" + "AyABKA0SFAoMaXNfaGFzX3Rha2VuGAQgASgIEg0KBWxldmVsGAsgASgNQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DailyActivityInfo), DailyActivityInfo.Parser, new string[]
			{
				"WorldLevel",
				"DailyActivePoint",
				"IsHasTaken",
				"Level"
			}, null, null, null, null)
		}));
	}
}
