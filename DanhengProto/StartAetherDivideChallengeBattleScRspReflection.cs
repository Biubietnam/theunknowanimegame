using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200118E RID: 4494
	public static class StartAetherDivideChallengeBattleScRspReflection
	{
		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600C8A1 RID: 51361 RVA: 0x0021A3A5 File Offset: 0x002185A5
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideChallengeBattleScRspReflection.descriptor;
			}
		}

		// Token: 0x040050FA RID: 20730
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitTdGFydEFldGhlckRpdmlkZUNoYWxsZW5nZUJhdHRsZVNjUnNwLnByb3Rv",
			"GhxBZXRoZXJEaXZpZGVCYXR0bGVJbmZvLnByb3RvImYKJVN0YXJ0QWV0aGVy",
			"RGl2aWRlQ2hhbGxlbmdlQmF0dGxlU2NSc3ASLAoLYmF0dGxlX2luZm8YCyAB",
			"KAsyFy5BZXRoZXJEaXZpZGVCYXR0bGVJbmZvEg8KB3JldGNvZGUYDCABKA1C",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AetherDivideBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideChallengeBattleScRsp), StartAetherDivideChallengeBattleScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
