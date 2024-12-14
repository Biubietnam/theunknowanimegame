using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D44 RID: 3396
	public static class QuitBattleCsReqReflection
	{
		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x060097C3 RID: 38851 RVA: 0x0019479D File Offset: 0x0019299D
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuitBattleCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003B09 RID: 15113
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVRdWl0QmF0dGxlQ3NSZXEucHJvdG8aElJlYmF0dGxlVHlwZS5wcm90bxoW",
			"QmF0dGxlU3RhdGlzdGljcy5wcm90byJXCg9RdWl0QmF0dGxlQ3NSZXESHgoD",
			"c3R0GAUgASgLMhEuQmF0dGxlU3RhdGlzdGljcxIkCg1yZWJhdHRsZV90eXBl",
			"GAQgASgOMg0uUmViYXR0bGVUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RebattleTypeReflection.Descriptor,
			BattleStatisticsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuitBattleCsReq), QuitBattleCsReq.Parser, new string[]
			{
				"Stt",
				"RebattleType"
			}, null, null, null, null)
		}));
	}
}
