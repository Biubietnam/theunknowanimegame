using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000256 RID: 598
	public static class ChessRogueNousEnableRogueTalentScRspReflection
	{
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0004D916 File Offset: 0x0004BB16
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousEnableRogueTalentScRspReflection.descriptor;
			}
		}

		// Token: 0x04000B58 RID: 2904
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipDaGVzc1JvZ3VlTm91c0VuYWJsZVJvZ3VlVGFsZW50U2NSc3AucHJvdG8a",
			"GVJvZ3VlVGFsZW50SW5mb0xpc3QucHJvdG8ifAokQ2hlc3NSb2d1ZU5vdXNF",
			"bmFibGVSb2d1ZVRhbGVudFNjUnNwEi4KEHRhbGVudF9pbmZvX2xpc3QYCiAB",
			"KAsyFC5Sb2d1ZVRhbGVudEluZm9MaXN0Eg8KB3JldGNvZGUYBCABKA0SEwoL",
			"RkNBQUdMS0ZBSUQYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTalentInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousEnableRogueTalentScRsp), ChessRogueNousEnableRogueTalentScRsp.Parser, new string[]
			{
				"TalentInfoList",
				"Retcode",
				"FCAAGLKFAID"
			}, null, null, null, null)
		}));
	}
}
