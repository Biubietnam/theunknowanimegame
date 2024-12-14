using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E2 RID: 2018
	public static class GetSaveRaidScRspReflection
	{
		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x000EFFDD File Offset: 0x000EE1DD
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetSaveRaidScRspReflection.descriptor;
			}
		}

		// Token: 0x040022EF RID: 8943
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZHZXRTYXZlUmFpZFNjUnNwLnByb3RvGhRSYWlkVGFyZ2V0SW5mby5wcm90",
			"byKKAQoQR2V0U2F2ZVJhaWRTY1JzcBIPCgdyYWlkX2lkGAEgASgNEhMKC3dv",
			"cmxkX2xldmVsGAYgASgNEhQKDGlzX3NhdmVfZGF0YRgCIAEoCBIPCgdyZXRj",
			"b2RlGA8gASgNEikKEHJhaWRfdGFyZ2V0X2luZm8YBCADKAsyDy5SYWlkVGFy",
			"Z2V0SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			RaidTargetInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetSaveRaidScRsp), GetSaveRaidScRsp.Parser, new string[]
			{
				"RaidId",
				"WorldLevel",
				"IsSaveData",
				"Retcode",
				"RaidTargetInfo"
			}, null, null, null, null)
		}));
	}
}
