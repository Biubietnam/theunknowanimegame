using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D6A RID: 3434
	public static class RaidDataReflection
	{
		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x06009978 RID: 39288 RVA: 0x001987B8 File Offset: 0x001969B8
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidDataReflection.descriptor;
			}
		}

		// Token: 0x04003B92 RID: 15250
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5SYWlkRGF0YS5wcm90bxoUUmFpZFRhcmdldEluZm8ucHJvdG8iWwoIUmFp" + "ZERhdGESKQoQcmFpZF90YXJnZXRfaW5mbxgFIAMoCzIPLlJhaWRUYXJnZXRJ" + "bmZvEhMKC3dvcmxkX2xldmVsGAwgASgNEg8KB3JhaWRfaWQYAiABKA1CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RaidTargetInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RaidData), RaidData.Parser, new string[]
			{
				"RaidTargetInfo",
				"WorldLevel",
				"RaidId"
			}, null, null, null, null)
		}));
	}
}
