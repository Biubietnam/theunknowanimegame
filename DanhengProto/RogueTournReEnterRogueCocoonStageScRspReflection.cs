using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FFE RID: 4094
	public static class RogueTournReEnterRogueCocoonStageScRspReflection
	{
		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600B631 RID: 46641 RVA: 0x001E8E82 File Offset: 0x001E7082
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournReEnterRogueCocoonStageScRspReflection.descriptor;
			}
		}

		// Token: 0x040049DA RID: 18906
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CixSb2d1ZVRvdXJuUmVFbnRlclJvZ3VlQ29jb29uU3RhZ2VTY1JzcC5wcm90",
			"bxoVU2NlbmVCYXR0bGVJbmZvLnByb3RvImAKJlJvZ3VlVG91cm5SZUVudGVy",
			"Um9ndWVDb2Nvb25TdGFnZVNjUnNwEiUKC2JhdHRsZV9pbmZvGAwgASgLMhAu",
			"U2NlbmVCYXR0bGVJbmZvEg8KB3JldGNvZGUYDyABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournReEnterRogueCocoonStageScRsp), RogueTournReEnterRogueCocoonStageScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
