using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008BA RID: 2234
	public static class HeliobusEnterBattleCsReqReflection
	{
		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x0600639F RID: 25503 RVA: 0x0010AE01 File Offset: 0x00109001
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusEnterBattleCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002669 RID: 9833
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5IZWxpb2J1c0VudGVyQmF0dGxlQ3NSZXEucHJvdG8iVgoYSGVsaW9idXNF" + "bnRlckJhdHRsZUNzUmVxEhAKCHNraWxsX2lkGAIgASgNEhYKDmF2YXRhcl9p" + "ZF9saXN0GA4gAygNEhAKCGV2ZW50X2lkGAggASgNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusEnterBattleCsReq), HeliobusEnterBattleCsReq.Parser, new string[]
			{
				"SkillId",
				"AvatarIdList",
				"EventId"
			}, null, null, null, null)
		}));
	}
}
