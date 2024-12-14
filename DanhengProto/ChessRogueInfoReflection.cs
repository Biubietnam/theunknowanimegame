using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000230 RID: 560
	public static class ChessRogueInfoReflection
	{
		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0004970D File Offset: 0x0004790D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueInfoReflection.descriptor;
			}
		}

		// Token: 0x04000ABF RID: 2751
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRDaGVzc1JvZ3VlSW5mby5wcm90bxoPU2NlbmVJbmZvLnByb3RvGhBMaW5l" + "dXBJbmZvLnByb3RvIkgKDkNoZXNzUm9ndWVJbmZvEhsKBmxpbmV1cBgBIAEo" + "CzILLkxpbmV1cEluZm8SGQoFc2NlbmUYDyABKAsyCi5TY2VuZUluZm9CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueInfo), ChessRogueInfo.Parser, new string[]
			{
				"Lineup",
				"Scene"
			}, null, null, null, null)
		}));
	}
}
