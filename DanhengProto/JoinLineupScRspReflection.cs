using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200097E RID: 2430
	public static class JoinLineupScRspReflection
	{
		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06006CBC RID: 27836 RVA: 0x001226CC File Offset: 0x001208CC
		public static FileDescriptor Descriptor
		{
			get
			{
				return JoinLineupScRspReflection.descriptor;
			}
		}

		// Token: 0x040029B1 RID: 10673
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVKb2luTGluZXVwU2NSc3AucHJvdG8iIgoPSm9pbkxpbmV1cFNjUnNwEg8K" + "B3JldGNvZGUYByABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(JoinLineupScRsp), JoinLineupScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
