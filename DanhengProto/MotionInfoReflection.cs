using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B96 RID: 2966
	public static class MotionInfoReflection
	{
		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x0600837C RID: 33660 RVA: 0x0015B23D File Offset: 0x0015943D
		public static FileDescriptor Descriptor
		{
			get
			{
				return MotionInfoReflection.descriptor;
			}
		}

		// Token: 0x0400324B RID: 12875
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBNb3Rpb25JbmZvLnByb3RvGgxWZWN0b3IucHJvdG8iOAoKTW90aW9uSW5m" + "bxIUCgNyb3QYAyABKAsyBy5WZWN0b3ISFAoDcG9zGAIgASgLMgcuVmVjdG9y" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			VectorReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MotionInfo), MotionInfo.Parser, new string[]
			{
				"Rot",
				"Pos"
			}, null, null, null, null)
		}));
	}
}
