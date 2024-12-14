using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004C4 RID: 1220
	public static class EvolveBuildStartLevelCsReqReflection
	{
		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x00095F1C File Offset: 0x0009411C
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildStartLevelCsReqReflection.descriptor;
			}
		}

		// Token: 0x040015B0 RID: 5552
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBFdm9sdmVCdWlsZFN0YXJ0TGV2ZWxDc1JlcS5wcm90bxoXRXZvbHZlQnVp",
			"bGRBdmF0YXIucHJvdG8aEU5HSUtHSEtNQUhBLnByb3RvInoKGkV2b2x2ZUJ1",
			"aWxkU3RhcnRMZXZlbENzUmVxEhAKCGxldmVsX2lkGAQgASgNEicKC2F2YXRh",
			"cl9saXN0GA0gAygLMhIuRXZvbHZlQnVpbGRBdmF0YXISIQoLSkpMRklCQUFK",
			"TkoYDCABKAsyDC5OR0lLR0hLTUFIQUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EvolveBuildAvatarReflection.Descriptor,
			NGIKGHKMAHAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartLevelCsReq), EvolveBuildStartLevelCsReq.Parser, new string[]
			{
				"LevelId",
				"AvatarList",
				"JJLFIBAAJNJ"
			}, null, null, null, null)
		}));
	}
}
