using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AB0 RID: 2736
	public static class MazePropStateReflection
	{
		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06007955 RID: 31061 RVA: 0x001418B8 File Offset: 0x0013FAB8
		public static FileDescriptor Descriptor
		{
			get
			{
				return MazePropStateReflection.descriptor;
			}
		}

		// Token: 0x04002E93 RID: 11923
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNYXplUHJvcFN0YXRlLnByb3RvIkMKDU1hemVQcm9wU3RhdGUSDQoFc3Rh" + "dGUYCCABKA0SEAoIZ3JvdXBfaWQYBSABKA0SEQoJY29uZmlnX2lkGAsgASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MazePropState), MazePropState.Parser, new string[]
			{
				"State",
				"GroupId",
				"ConfigId"
			}, null, null, null, null)
		}));
	}
}
