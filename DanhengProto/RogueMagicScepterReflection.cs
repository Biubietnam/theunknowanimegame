using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F00 RID: 3840
	public static class RogueMagicScepterReflection
	{
		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0600AB79 RID: 43897 RVA: 0x001CDE03 File Offset: 0x001CC003
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterReflection.descriptor;
			}
		}

		// Token: 0x040045FC RID: 17916
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSb2d1ZU1hZ2ljU2NlcHRlci5wcm90byI2ChFSb2d1ZU1hZ2ljU2NlcHRl" + "chISCgpzY2VwdGVyX2lkGA4gASgNEg0KBWxldmVsGAMgASgNQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicScepter), RogueMagicScepter.Parser, new string[]
			{
				"ScepterId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
