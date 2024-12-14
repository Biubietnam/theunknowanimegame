using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FEC RID: 4076
	public static class RogueTournLevelInfoReflection
	{
		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600B578 RID: 46456 RVA: 0x001E718D File Offset: 0x001E538D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournLevelInfoReflection.descriptor;
			}
		}

		// Token: 0x04004997 RID: 18839
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlSb2d1ZVRvdXJuTGV2ZWxJbmZvLnByb3RvGhVSb2d1ZVRvdXJuTGV2ZWwu",
			"cHJvdG8aHFJvZ3VlVG91cm5TZXR0bGVSZWFzb24ucHJvdG8aG1JvZ3VlVG91",
			"cm5MZXZlbFN0YXR1cy5wcm90byKqAQoTUm9ndWVUb3VybkxldmVsSW5mbxIp",
			"Cg9sZXZlbF9pbmZvX2xpc3QYDSADKAsyEC5Sb2d1ZVRvdXJuTGV2ZWwSFwoP",
			"Y3VyX2xldmVsX2luZGV4GAggASgNEiYKBnN0YXR1cxgGIAEoDjIWLlJvZ3Vl",
			"VG91cm5MZXZlbFN0YXR1cxInCgZyZWFzb24YASABKA4yFy5Sb2d1ZVRvdXJu",
			"U2V0dGxlUmVhc29uQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTournLevelReflection.Descriptor,
			RogueTournSettleReasonReflection.Descriptor,
			RogueTournLevelStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLevelInfo), RogueTournLevelInfo.Parser, new string[]
			{
				"LevelInfoList",
				"CurLevelIndex",
				"Status",
				"Reason"
			}, null, null, null, null)
		}));
	}
}
