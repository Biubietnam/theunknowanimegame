using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D6E RID: 3438
	public static class RaidKickByServerScNotifyReflection
	{
		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x060099AE RID: 39342 RVA: 0x0019924B File Offset: 0x0019744B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidKickByServerScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003BAC RID: 15276
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5SYWlkS2lja0J5U2VydmVyU2NOb3RpZnkucHJvdG8aEUVHSERBQkJCTkpP",
			"LnByb3RvGhBMaW5ldXBJbmZvLnByb3RvGg9TY2VuZUluZm8ucHJvdG8ilgEK",
			"GFJhaWRLaWNrQnlTZXJ2ZXJTY05vdGlmeRIPCgdyYWlkX2lkGAsgASgNEhMK",
			"C3dvcmxkX2xldmVsGAwgASgNEhkKBXNjZW5lGAcgASgLMgouU2NlbmVJbmZv",
			"EhwKBnJlYXNvbhgOIAEoDjIMLkVHSERBQkJCTkpPEhsKBmxpbmV1cBgJIAEo",
			"CzILLkxpbmV1cEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			EGHDABBBNJOReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RaidKickByServerScNotify), RaidKickByServerScNotify.Parser, new string[]
			{
				"RaidId",
				"WorldLevel",
				"Scene",
				"Reason",
				"Lineup"
			}, null, null, null, null)
		}));
	}
}
