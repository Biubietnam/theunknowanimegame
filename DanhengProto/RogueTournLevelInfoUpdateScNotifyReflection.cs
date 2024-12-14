using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FEE RID: 4078
	public static class RogueTournLevelInfoUpdateScNotifyReflection
	{
		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600B592 RID: 46482 RVA: 0x001E768F File Offset: 0x001E588F
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournLevelInfoUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040049A3 RID: 18851
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidSb2d1ZVRvdXJuTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkucHJvdG8aG1Jv",
			"Z3VlVG91cm5MZXZlbFN0YXR1cy5wcm90bxoVUm9ndWVUb3VybkxldmVsLnBy",
			"b3RvGhxSb2d1ZVRvdXJuU2V0dGxlUmVhc29uLnByb3RvIrgBCiFSb2d1ZVRv",
			"dXJuTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkSJgoGc3RhdHVzGAUgASgOMhYu",
			"Um9ndWVUb3VybkxldmVsU3RhdHVzEicKBnJlYXNvbhgEIAEoDjIXLlJvZ3Vl",
			"VG91cm5TZXR0bGVSZWFzb24SKQoPbGV2ZWxfaW5mb19saXN0GAggAygLMhAu",
			"Um9ndWVUb3VybkxldmVsEhcKD2N1cl9sZXZlbF9pbmRleBgJIAEoDUIeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournLevelStatusReflection.Descriptor,
			RogueTournLevelReflection.Descriptor,
			RogueTournSettleReasonReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLevelInfoUpdateScNotify), RogueTournLevelInfoUpdateScNotify.Parser, new string[]
			{
				"Status",
				"Reason",
				"LevelInfoList",
				"CurLevelIndex"
			}, null, null, null, null)
		}));
	}
}
