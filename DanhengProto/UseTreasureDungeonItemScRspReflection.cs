using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200140E RID: 5134
	public static class UseTreasureDungeonItemScRspReflection
	{
		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x0600E510 RID: 58640 RVA: 0x0026123C File Offset: 0x0025F43C
		public static FileDescriptor Descriptor
		{
			get
			{
				return UseTreasureDungeonItemScRspReflection.descriptor;
			}
		}

		// Token: 0x04005AFF RID: 23295
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFVc2VUcmVhc3VyZUR1bmdlb25JdGVtU2NSc3AucHJvdG8aGlRyZWFzdXJl",
			"RHVuZ2VvbkxldmVsLnByb3RvIloKG1VzZVRyZWFzdXJlRHVuZ2Vvbkl0ZW1T",
			"Y1JzcBIqCgtMSElFQ0tQSk5GRBgFIAEoCzIVLlRyZWFzdXJlRHVuZ2Vvbkxl",
			"dmVsEg8KB3JldGNvZGUYByABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			TreasureDungeonLevelReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UseTreasureDungeonItemScRsp), UseTreasureDungeonItemScRsp.Parser, new string[]
			{
				"LHIECKPJNFD",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
