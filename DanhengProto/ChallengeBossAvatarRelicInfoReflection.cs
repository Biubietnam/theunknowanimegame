using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000190 RID: 400
	public static class ChallengeBossAvatarRelicInfoReflection
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000339F2 File Offset: 0x00031BF2
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossAvatarRelicInfoReflection.descriptor;
			}
		}

		// Token: 0x04000787 RID: 1927
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJDaGFsbGVuZ2VCb3NzQXZhdGFyUmVsaWNJbmZvLnByb3RvGhxDaGFsbGVu",
			"Z2VCb3NzUmVsaWNJbmZvLnByb3RvIsgBChxDaGFsbGVuZ2VCb3NzQXZhdGFy",
			"UmVsaWNJbmZvElQKFWF2YXRhcl9yZWxpY19zbG90X21hcBgEIAMoCzI1LkNo",
			"YWxsZW5nZUJvc3NBdmF0YXJSZWxpY0luZm8uQXZhdGFyUmVsaWNTbG90TWFw",
			"RW50cnkaUgoXQXZhdGFyUmVsaWNTbG90TWFwRW50cnkSCwoDa2V5GAEgASgN",
			"EiYKBXZhbHVlGAIgASgLMhcuQ2hhbGxlbmdlQm9zc1JlbGljSW5mbzoCOAFC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChallengeBossRelicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossAvatarRelicInfo), ChallengeBossAvatarRelicInfo.Parser, new string[]
			{
				"AvatarRelicSlotMap"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
