using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200129E RID: 4766
	public static class SyncRogueStatusScNotifyReflection
	{
		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600D4A9 RID: 54441 RVA: 0x00237E19 File Offset: 0x00236019
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueStatusScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005516 RID: 21782
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TeW5jUm9ndWVTdGF0dXNTY05vdGlmeS5wcm90bxoRUm9ndWVTdGF0dXMu" + "cHJvdG8iTAoXU3luY1JvZ3VlU3RhdHVzU2NOb3RpZnkSEwoLTU1HRkNJTElD" + "TkQYBSABKAgSHAoGc3RhdHVzGAcgASgOMgwuUm9ndWVTdGF0dXNCHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RogueStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueStatusScNotify), SyncRogueStatusScNotify.Parser, new string[]
			{
				"MMGFCILICND",
				"Status"
			}, null, null, null, null)
		}));
	}
}
