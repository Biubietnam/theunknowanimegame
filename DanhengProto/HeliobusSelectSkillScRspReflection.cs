using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C4 RID: 2244
	public static class HeliobusSelectSkillScRspReflection
	{
		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06006414 RID: 25620 RVA: 0x0010C07E File Offset: 0x0010A27E
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusSelectSkillScRspReflection.descriptor;
			}
		}

		// Token: 0x04002692 RID: 9874
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5IZWxpb2J1c1NlbGVjdFNraWxsU2NSc3AucHJvdG8iPQoYSGVsaW9idXNT" + "ZWxlY3RTa2lsbFNjUnNwEhAKCHNraWxsX2lkGAwgASgNEg8KB3JldGNvZGUY" + "CyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSelectSkillScRsp), HeliobusSelectSkillScRsp.Parser, new string[]
			{
				"SkillId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
