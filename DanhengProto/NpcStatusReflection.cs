using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C38 RID: 3128
	public static class NpcStatusReflection
	{
		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x06008AB7 RID: 35511 RVA: 0x0016E6DB File Offset: 0x0016C8DB
		public static FileDescriptor Descriptor
		{
			get
			{
				return NpcStatusReflection.descriptor;
			}
		}

		// Token: 0x04003538 RID: 13624
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9OcGNTdGF0dXMucHJvdG8iLgoJTnBjU3RhdHVzEg4KBm5wY19pZBgEIAEo" + "DRIRCglpc19maW5pc2gYDyABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NpcStatus), NpcStatus.Parser, new string[]
			{
				"NpcId",
				"IsFinish"
			}, null, null, null, null)
		}));
	}
}
