using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008D8 RID: 2264
	public static class HeliobusStartRaidCsReqReflection
	{
		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x060064F9 RID: 25849 RVA: 0x0010E138 File Offset: 0x0010C338
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusStartRaidCsReqReflection.descriptor;
			}
		}

		// Token: 0x040026D9 RID: 9945
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxIZWxpb2J1c1N0YXJ0UmFpZENzUmVxLnByb3RvIpMBChZIZWxpb2J1c1N0",
			"YXJ0UmFpZENzUmVxEhYKDnByb3BfZW50aXR5X2lkGAIgASgNEhAKCHNraWxs",
			"X2lkGA8gASgNEhQKDGlzX3NhdmVfZGF0YRgGIAEoCBIPCgdyYWlkX2lkGAMg",
			"ASgNEhMKC2F2YXRhcl9saXN0GAogAygNEhMKC0pGUE9CTEdPUENQGAUgASgN",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusStartRaidCsReq), HeliobusStartRaidCsReq.Parser, new string[]
			{
				"PropEntityId",
				"SkillId",
				"IsSaveData",
				"RaidId",
				"AvatarList",
				"JFPOBLGOPCP"
			}, null, null, null, null)
		}));
	}
}
