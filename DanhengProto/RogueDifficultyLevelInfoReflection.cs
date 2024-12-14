using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E70 RID: 3696
	public static class RogueDifficultyLevelInfoReflection
	{
		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0600A4ED RID: 42221 RVA: 0x001BB5B4 File Offset: 0x001B97B4
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueDifficultyLevelInfoReflection.descriptor;
			}
		}

		// Token: 0x04004362 RID: 17250
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZURpZmZpY3VsdHlMZXZlbEluZm8ucHJvdG8iNgoYUm9ndWVEaWZm" + "aWN1bHR5TGV2ZWxJbmZvEhoKEmRpZmZpY3VsdHlfaWRfbGlzdBgBIAMoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueDifficultyLevelInfo), RogueDifficultyLevelInfo.Parser, new string[]
			{
				"DifficultyIdList"
			}, null, null, null, null)
		}));
	}
}
