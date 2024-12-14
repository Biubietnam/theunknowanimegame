using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E2 RID: 1506
	public static class GameplayCounterUpdateScNotifyReflection
	{
		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x000B6DE7 File Offset: 0x000B4FE7
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameplayCounterUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04001AAC RID: 6828
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNHYW1lcGxheUNvdW50ZXJVcGRhdGVTY05vdGlmeS5wcm90bxohR2FtZXBs",
			"YXlDb3VudGVyVXBkYXRlUmVhc29uLnByb3RvIncKHUdhbWVwbGF5Q291bnRl",
			"clVwZGF0ZVNjTm90aWZ5EhMKC05OQ0ZQRExDTkhOGAwgASgNEhMKC0dFRUpQ",
			"SE5ISE9EGAQgASgNEiwKBnJlYXNvbhgDIAEoDjIcLkdhbWVwbGF5Q291bnRl",
			"clVwZGF0ZVJlYXNvbkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			GameplayCounterUpdateReasonReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GameplayCounterUpdateScNotify), GameplayCounterUpdateScNotify.Parser, new string[]
			{
				"NNCFPDLCNHN",
				"GEEJPHNHHOD",
				"Reason"
			}, null, null, null, null)
		}));
	}
}
