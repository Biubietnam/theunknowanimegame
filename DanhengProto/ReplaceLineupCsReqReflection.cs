using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB8 RID: 3512
	public static class ReplaceLineupCsReqReflection
	{
		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x06009D0F RID: 40207 RVA: 0x001A2570 File Offset: 0x001A0770
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReplaceLineupCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003D0C RID: 15628
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSZXBsYWNlTGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5w",
			"cm90bxoUTGluZXVwU2xvdERhdGEucHJvdG8i0gEKElJlcGxhY2VMaW5ldXBD",
			"c1JlcRINCgVpbmRleBgNIAEoDRITCgtsZWFkZXJfc2xvdBgOIAEoDRISCgpp",
			"c192aXJ0dWFsGAMgASgIEhAKCHBsYW5lX2lkGAEgASgNEisKEWV4dHJhX2xp",
			"bmV1cF90eXBlGAIgASgOMhAuRXh0cmFMaW5ldXBUeXBlEhoKEmdhbWVfc3Rv",
			"cnlfbGluZV9pZBgIIAEoDRIpChBsaW5ldXBfc2xvdF9saXN0GAsgAygLMg8u",
			"TGluZXVwU2xvdERhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ExtraLineupTypeReflection.Descriptor,
			LineupSlotDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReplaceLineupCsReq), ReplaceLineupCsReq.Parser, new string[]
			{
				"Index",
				"LeaderSlot",
				"IsVirtual",
				"PlaneId",
				"ExtraLineupType",
				"GameStoryLineId",
				"LineupSlotList"
			}, null, null, null, null)
		}));
	}
}
