using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007C2 RID: 1986
	public static class GetRogueInfoScRspReflection
	{
		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x000ECBA2 File Offset: 0x000EADA2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002283 RID: 8835
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRSb2d1ZUluZm9TY1JzcC5wcm90bxoPUm9ndWVJbmZvLnByb3RvIkkK" + "EUdldFJvZ3VlSW5mb1NjUnNwEiMKD3JvZ3VlX2dhbWVfaW5mbxgKIAEoCzIK" + "LlJvZ3VlSW5mbxIPCgdyZXRjb2RlGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueInfoScRsp), GetRogueInfoScRsp.Parser, new string[]
			{
				"RogueGameInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
