using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200046E RID: 1134
	public static class EnterSummonActivityStageCsReqReflection
	{
		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x0008B02B File Offset: 0x0008922B
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSummonActivityStageCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001420 RID: 5152
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNFbnRlclN1bW1vbkFjdGl2aXR5U3RhZ2VDc1JlcS5wcm90bxoRUE1DRk1I",
			"SkdLQ0UucHJvdG8ijAEKHUVudGVyU3VtbW9uQWN0aXZpdHlTdGFnZUNzUmVx",
			"EhMKC0FIRk5HUExEQUlJGAkgASgNEhAKCGdyb3VwX2lkGAIgASgNEiEKC2F2",
			"YXRhcl9saXN0GAYgAygLMgwuUE1DRk1ISkdLQ0USIQoLUEhOT0xQTk5KQ0UY",
			"CyABKAsyDC5QTUNGTUhKR0tDRUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PMCFMHJGKCEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSummonActivityStageCsReq), EnterSummonActivityStageCsReq.Parser, new string[]
			{
				"AHFNGPLDAII",
				"GroupId",
				"AvatarList",
				"PHNOLPNNJCE"
			}, null, null, null, null)
		}));
	}
}
