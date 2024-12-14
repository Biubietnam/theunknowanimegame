using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011CE RID: 4558
	public static class StartTimedCocoonStageScRspReflection
	{
		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600CBC0 RID: 52160 RVA: 0x00222F60 File Offset: 0x00221160
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartTimedCocoonStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04005233 RID: 21043
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBTdGFydFRpbWVkQ29jb29uU3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
			"bGVJbmZvLnByb3RvInUKGlN0YXJ0VGltZWRDb2Nvb25TdGFnZVNjUnNwEg8K",
			"B3JldGNvZGUYDSABKA0SEQoJY29jb29uX2lkGAcgASgNEgwKBHdhdmUYCyAB",
			"KA0SJQoLYmF0dGxlX2luZm8YDiABKAsyEC5TY2VuZUJhdHRsZUluZm9CHqoC",
			"G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartTimedCocoonStageScRsp), StartTimedCocoonStageScRsp.Parser, new string[]
			{
				"Retcode",
				"CocoonId",
				"Wave",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
