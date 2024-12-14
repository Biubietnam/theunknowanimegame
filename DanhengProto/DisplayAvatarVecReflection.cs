using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003AE RID: 942
	public static class DisplayAvatarVecReflection
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x00074A84 File Offset: 0x00072C84
		public static FileDescriptor Descriptor
		{
			get
			{
				return DisplayAvatarVecReflection.descriptor;
			}
		}

		// Token: 0x040010F0 RID: 4336
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEaXNwbGF5QXZhdGFyVmVjLnByb3RvGhdEaXNwbGF5QXZhdGFyRGF0YS5w" + "cm90byJXChBEaXNwbGF5QXZhdGFyVmVjEi8KE2Rpc3BsYXlfYXZhdGFyX2xp" + "c3QYBSADKAsyEi5EaXNwbGF5QXZhdGFyRGF0YRISCgppc19kaXNwbGF5GAYg" + "ASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			DisplayAvatarDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DisplayAvatarVec), DisplayAvatarVec.Parser, new string[]
			{
				"DisplayAvatarList",
				"IsDisplay"
			}, null, null, null, null)
		}));
	}
}
