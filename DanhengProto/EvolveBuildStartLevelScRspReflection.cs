using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004C6 RID: 1222
	public static class EvolveBuildStartLevelScRspReflection
	{
		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x00096389 File Offset: 0x00094589
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildStartLevelScRspReflection.descriptor;
			}
		}

		// Token: 0x040015BA RID: 5562
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBFdm9sdmVCdWlsZFN0YXJ0TGV2ZWxTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
			"bGVJbmZvLnByb3RvGhpFdm9sdmVCdWlsZExldmVsSW5mby5wcm90byJ/ChpF",
			"dm9sdmVCdWlsZFN0YXJ0TGV2ZWxTY1JzcBIpCgpsZXZlbF9pbmZvGAwgASgL",
			"MhUuRXZvbHZlQnVpbGRMZXZlbEluZm8SDwoHcmV0Y29kZRgFIAEoDRIlCgtL",
			"RlBEUEJCQU9QTBgGIAEoCzIQLlNjZW5lQmF0dGxlSW5mb0IeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor,
			EvolveBuildLevelInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartLevelScRsp), EvolveBuildStartLevelScRsp.Parser, new string[]
			{
				"LevelInfo",
				"Retcode",
				"KFPDPBBAOPL"
			}, null, null, null, null)
		}));
	}
}
