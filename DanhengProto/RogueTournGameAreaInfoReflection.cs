using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FBC RID: 4028
	public static class RogueTournGameAreaInfoReflection
	{
		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600B384 RID: 45956 RVA: 0x001E22D2 File Offset: 0x001E04D2
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournGameAreaInfoReflection.descriptor;
			}
		}

		// Token: 0x040048DE RID: 18654
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZVRvdXJuR2FtZUFyZWFJbmZvLnByb3RvIkEKFlJvZ3VlVG91cm5H" + "YW1lQXJlYUluZm8SEQoJZ2FtZV93ZWVrGAYgASgNEhQKDGdhbWVfYXJlYV9p" + "ZBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGameAreaInfo), RogueTournGameAreaInfo.Parser, new string[]
			{
				"GameWeek",
				"GameAreaId"
			}, null, null, null, null)
		}));
	}
}
