using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F9E RID: 3998
	public static class RogueTournEnablePermanentTalentScRspReflection
	{
		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600B22C RID: 45612 RVA: 0x001DED22 File Offset: 0x001DCF22
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournEnablePermanentTalentScRspReflection.descriptor;
			}
		}

		// Token: 0x04004870 RID: 18544
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipSb2d1ZVRvdXJuRW5hYmxlUGVybWFuZW50VGFsZW50U2NSc3AucHJvdG8a",
			"I1JvZ3VlVG91cm5QZXJtYW5lbnRUYWxlbnRJbmZvLnByb3RvIm8KJFJvZ3Vl",
			"VG91cm5FbmFibGVQZXJtYW5lbnRUYWxlbnRTY1JzcBI2Cg5wZXJtYW5lbnRf",
			"aW5mbxgPIAEoCzIeLlJvZ3VlVG91cm5QZXJtYW5lbnRUYWxlbnRJbmZvEg8K",
			"B3JldGNvZGUYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournPermanentTalentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnablePermanentTalentScRsp), RogueTournEnablePermanentTalentScRsp.Parser, new string[]
			{
				"PermanentInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
