using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001412 RID: 5138
	public static class VideoKeyInfoReflection
	{
		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x0600E540 RID: 58688 RVA: 0x002619D8 File Offset: 0x0025FBD8
		public static FileDescriptor Descriptor
		{
			get
			{
				return VideoKeyInfoReflection.descriptor;
			}
		}

		// Token: 0x04005B0F RID: 23311
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJWaWRlb0tleUluZm8ucHJvdG8iLQoMVmlkZW9LZXlJbmZvEgoKAmlkGAgg" + "ASgNEhEKCXZpZGVvX2tleRgGIAEoBEIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(VideoKeyInfo), VideoKeyInfo.Parser, new string[]
			{
				"Id",
				"VideoKey"
			}, null, null, null, null)
		}));
	}
}
