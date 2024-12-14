using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A82 RID: 2690
	public static class MarkAvatarScRspReflection
	{
		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06007745 RID: 30533 RVA: 0x0013C635 File Offset: 0x0013A835
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04002DCE RID: 11726
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVNYXJrQXZhdGFyU2NSc3AucHJvdG8iSAoPTWFya0F2YXRhclNjUnNwEg8K" + "B3JldGNvZGUYCSABKA0SEQoJaXNfbWFya2VkGAcgASgIEhEKCWF2YXRhcl9p" + "ZBgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkAvatarScRsp), MarkAvatarScRsp.Parser, new string[]
			{
				"Retcode",
				"IsMarked",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
