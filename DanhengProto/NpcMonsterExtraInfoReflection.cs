using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C32 RID: 3122
	public static class NpcMonsterExtraInfoReflection
	{
		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x06008A62 RID: 35426 RVA: 0x0016D645 File Offset: 0x0016B845
		public static FileDescriptor Descriptor
		{
			get
			{
				return NpcMonsterExtraInfoReflection.descriptor;
			}
		}

		// Token: 0x0400350F RID: 13583
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlOcGNNb25zdGVyRXh0cmFJbmZvLnByb3RvGhlOcGNNb25zdGVyUm9ndWVJ" + "bmZvLnByb3RvIkQKE05wY01vbnN0ZXJFeHRyYUluZm8SLQoPcm9ndWVfZ2Ft" + "ZV9pbmZvGAMgASgLMhQuTnBjTW9uc3RlclJvZ3VlSW5mb0IeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			NpcMonsterRogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NpcMonsterExtraInfo), NpcMonsterExtraInfo.Parser, new string[]
			{
				"RogueGameInfo"
			}, null, null, null, null)
		}));
	}
}
