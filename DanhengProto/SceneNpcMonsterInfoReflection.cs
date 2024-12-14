using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001082 RID: 4226
	public static class SceneNpcMonsterInfoReflection
	{
		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0600BC67 RID: 48231 RVA: 0x001FBB78 File Offset: 0x001F9D78
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneNpcMonsterInfoReflection.descriptor;
			}
		}

		// Token: 0x04004C9D RID: 19613
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTY2VuZU5wY01vbnN0ZXJJbmZvLnByb3RvGhlOcGNNb25zdGVyRXh0cmFJ",
			"bmZvLnByb3RvIqQBChNTY2VuZU5wY01vbnN0ZXJJbmZvEigKCmV4dHJhX2lu",
			"Zm8YBCABKAsyFC5OcGNNb25zdGVyRXh0cmFJbmZvEhMKC3dvcmxkX2xldmVs",
			"GAUgASgNEhMKC0xMTkRITklHSk1JGAwgASgIEhMKC0hIR0pMRUxBREtPGA0g",
			"ASgIEhIKCm1vbnN0ZXJfaWQYByABKA0SEAoIZXZlbnRfaWQYAiABKA1CHqoC",
			"G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			NpcMonsterExtraInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneNpcMonsterInfo), SceneNpcMonsterInfo.Parser, new string[]
			{
				"ExtraInfo",
				"WorldLevel",
				"LLNDHNIGJMI",
				"HHGJLELADKO",
				"MonsterId",
				"EventId"
			}, null, null, null, null)
		}));
	}
}
