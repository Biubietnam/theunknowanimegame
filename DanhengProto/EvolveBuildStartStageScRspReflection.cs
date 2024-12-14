using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004CA RID: 1226
	public static class EvolveBuildStartStageScRspReflection
	{
		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x00096A9E File Offset: 0x00094C9E
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildStartStageScRspReflection.descriptor;
			}
		}

		// Token: 0x040015C8 RID: 5576
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBFdm9sdmVCdWlsZFN0YXJ0U3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
			"bGVJbmZvLnByb3RvGhpFdm9sdmVCdWlsZExldmVsSW5mby5wcm90byJ/ChpF",
			"dm9sdmVCdWlsZFN0YXJ0U3RhZ2VTY1JzcBIPCgdyZXRjb2RlGAMgASgNEiUK",
			"C0tGUERQQkJBT1BMGAogASgLMhAuU2NlbmVCYXR0bGVJbmZvEikKCmxldmVs",
			"X2luZm8YByABKAsyFS5Fdm9sdmVCdWlsZExldmVsSW5mb0IeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor,
			EvolveBuildLevelInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartStageScRsp), EvolveBuildStartStageScRsp.Parser, new string[]
			{
				"Retcode",
				"KFPDPBBAOPL",
				"LevelInfo"
			}, null, null, null, null)
		}));
	}
}
