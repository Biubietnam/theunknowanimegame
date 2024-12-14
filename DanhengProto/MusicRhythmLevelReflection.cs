using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BE2 RID: 3042
	public static class MusicRhythmLevelReflection
	{
		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x060086AF RID: 34479 RVA: 0x001638B9 File Offset: 0x00161AB9
		public static FileDescriptor Descriptor
		{
			get
			{
				return MusicRhythmLevelReflection.descriptor;
			}
		}

		// Token: 0x0400339D RID: 13213
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZNdXNpY1JoeXRobUxldmVsLnByb3RvIlEKEE11c2ljUmh5dGhtTGV2ZWwS" + "FAoMdW5sb2NrX2xldmVsGA0gASgNEhUKDWlzX2Z1bGxfY29tYm8YCCABKAgS" + "EAoIbGV2ZWxfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmLevel), MusicRhythmLevel.Parser, new string[]
			{
				"UnlockLevel",
				"IsFullCombo",
				"LevelId"
			}, null, null, null, null)
		}));
	}
}
