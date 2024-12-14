using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000628 RID: 1576
	public static class GetAvatarDataScRspReflection
	{
		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x000C177F File Offset: 0x000BF97F
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAvatarDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001C3C RID: 7228
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhHZXRBdmF0YXJEYXRhU2NSc3AucHJvdG8aDEF2YXRhci5wcm90byJsChJH",
			"ZXRBdmF0YXJEYXRhU2NSc3ASHAoLYXZhdGFyX2xpc3QYBSADKAsyBy5BdmF0",
			"YXISEwoLS0FIQkJMQUtCQk4YAiADKA0SEgoKaXNfZ2V0X2FsbBgHIAEoCBIP",
			"CgdyZXRjb2RlGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			AvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAvatarDataScRsp), GetAvatarDataScRsp.Parser, new string[]
			{
				"AvatarList",
				"KAHBBLAKBBN",
				"IsGetAll",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
