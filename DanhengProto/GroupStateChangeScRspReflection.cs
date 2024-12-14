using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200087E RID: 2174
	public static class GroupStateChangeScRspReflection
	{
		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060060B2 RID: 24754 RVA: 0x000FF999 File Offset: 0x000FDB99
		public static FileDescriptor Descriptor
		{
			get
			{
				return GroupStateChangeScRspReflection.descriptor;
			}
		}

		// Token: 0x04002529 RID: 9513
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHcm91cFN0YXRlQ2hhbmdlU2NSc3AucHJvdG8aFEdyb3VwU3RhdGVJbmZv" + "LnByb3RvIlMKFUdyb3VwU3RhdGVDaGFuZ2VTY1JzcBIpChBncm91cF9zdGF0" + "ZV9pbmZvGAQgASgLMg8uR3JvdXBTdGF0ZUluZm8SDwoHcmV0Y29kZRgPIAEo" + "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			GroupStateInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateChangeScRsp), GroupStateChangeScRsp.Parser, new string[]
			{
				"GroupStateInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
