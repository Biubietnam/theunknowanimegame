using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001274 RID: 4724
	public static class SyncHandleFriendScNotifyReflection
	{
		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x0600D2E2 RID: 53986 RVA: 0x0023344C File Offset: 0x0023164C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncHandleFriendScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005474 RID: 21620
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5TeW5jSGFuZGxlRnJpZW5kU2NOb3RpZnkucHJvdG8aFkZyaWVuZFNpbXBs",
			"ZUluZm8ucHJvdG8iYgoYU3luY0hhbmRsZUZyaWVuZFNjTm90aWZ5EgsKA3Vp",
			"ZBgMIAEoDRIRCglpc19hY2NlcHQYCiABKAgSJgoLZnJpZW5kX2luZm8YDiAB",
			"KAsyES5GcmllbmRTaW1wbGVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			FriendSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncHandleFriendScNotify), SyncHandleFriendScNotify.Parser, new string[]
			{
				"Uid",
				"IsAccept",
				"FriendInfo"
			}, null, null, null, null)
		}));
	}
}
