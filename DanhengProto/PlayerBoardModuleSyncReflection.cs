using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB0 RID: 3248
	public static class PlayerBoardModuleSyncReflection
	{
		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600906C RID: 36972 RVA: 0x0017D7E6 File Offset: 0x0017B9E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerBoardModuleSyncReflection.descriptor;
			}
		}

		// Token: 0x04003785 RID: 14213
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtQbGF5ZXJCb2FyZE1vZHVsZVN5bmMucHJvdG8aEkhlYWRJY29uRGF0YS5w",
			"cm90byJvChVQbGF5ZXJCb2FyZE1vZHVsZVN5bmMSLgoXdW5sb2NrZWRfaGVh",
			"ZF9pY29uX2xpc3QYAiADKAsyDS5IZWFkSWNvbkRhdGESEwoLS09JTUdCTUxP",
			"UEIYCSABKAgSEQoJc2lnbmF0dXJlGAQgASgJQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			HeadIconDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerBoardModuleSync), PlayerBoardModuleSync.Parser, new string[]
			{
				"UnlockedHeadIconList",
				"KOIMGBMLOPB",
				"Signature"
			}, null, null, null, null)
		}));
	}
}
