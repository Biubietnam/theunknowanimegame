using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200105C RID: 4188
	public static class SceneEnterStageScRspReflection
	{
		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600BA87 RID: 47751 RVA: 0x001F5600 File Offset: 0x001F3800
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEnterStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04004BA5 RID: 19365
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTY2VuZUVudGVyU3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0bGVJbmZv" + "LnByb3RvIk4KFFNjZW5lRW50ZXJTdGFnZVNjUnNwEg8KB3JldGNvZGUYDiAB" + "KA0SJQoLYmF0dGxlX2luZm8YBCABKAsyEC5TY2VuZUJhdHRsZUluZm9CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEnterStageScRsp), SceneEnterStageScRsp.Parser, new string[]
			{
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
