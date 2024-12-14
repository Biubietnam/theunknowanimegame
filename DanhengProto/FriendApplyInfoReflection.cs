using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005C0 RID: 1472
	public static class FriendApplyInfoReflection
	{
		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x000B32BA File Offset: 0x000B14BA
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendApplyInfoReflection.descriptor;
			}
		}

		// Token: 0x04001A1A RID: 6682
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVGcmllbmRBcHBseUluZm8ucHJvdG8aFlBsYXllclNpbXBsZUluZm8ucHJv" + "dG8iTQoPRnJpZW5kQXBwbHlJbmZvEhIKCmFwcGx5X3RpbWUYDyABKAMSJgoL" + "cGxheWVyX2luZm8YCSABKAsyES5QbGF5ZXJTaW1wbGVJbmZvQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendApplyInfo), FriendApplyInfo.Parser, new string[]
			{
				"ApplyTime",
				"PlayerInfo"
			}, null, null, null, null)
		}));
	}
}
