using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200023A RID: 570
	public static class ChessRogueLevelInfoReflection
	{
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x0004ACD0 File Offset: 0x00048ED0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueLevelInfoReflection.descriptor;
			}
		}

		// Token: 0x04000AEC RID: 2796
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlDaGVzc1JvZ3VlTGV2ZWxJbmZvLnByb3RvGhhDaGVzc1JvZ3VlQXJlYUlu",
			"Zm8ucHJvdG8i5gEKE0NoZXNzUm9ndWVMZXZlbEluZm8SEAoIbGF5ZXJfaWQY",
			"CCABKA0SFAoMYWN0aW9uX3BvaW50GAkgASgFEhQKDGxldmVsX3N0YXR1cxgP",
			"IAEoDRIKCgJpZBgLIAEoDRITCgtPTkRQR0FOT0xKQRgMIAEoBRIUCgxhcmVh",
			"X2lkX2xpc3QYAiADKA0SEwoLQ05ORU1KSUpORUIYAyABKA0SHQoVZXhwbG9y",
			"ZWRfYXJlYV9pZF9saXN0GAUgAygNEiYKCWFyZWFfaW5mbxgKIAEoCzITLkNo",
			"ZXNzUm9ndWVBcmVhSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueAreaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLevelInfo), ChessRogueLevelInfo.Parser, new string[]
			{
				"LayerId",
				"ActionPoint",
				"LevelStatus",
				"Id",
				"ONDPGANOLJA",
				"AreaIdList",
				"CNNEMJIJNEB",
				"ExploredAreaIdList",
				"AreaInfo"
			}, null, null, null, null)
		}));
	}
}
