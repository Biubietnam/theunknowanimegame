using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001262 RID: 4706
	public static class SyncApplyFriendScNotifyReflection
	{
		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600D223 RID: 53795 RVA: 0x00231B9A File Offset: 0x0022FD9A
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncApplyFriendScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005441 RID: 21569
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TeW5jQXBwbHlGcmllbmRTY05vdGlmeS5wcm90bxoVRnJpZW5kQXBwbHlJ" + "bmZvLnByb3RvIj8KF1N5bmNBcHBseUZyaWVuZFNjTm90aWZ5EiQKCmFwcGx5" + "X2luZm8YDCABKAsyEC5GcmllbmRBcHBseUluZm9CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			FriendApplyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncApplyFriendScNotify), SyncApplyFriendScNotify.Parser, new string[]
			{
				"ApplyInfo"
			}, null, null, null, null)
		}));
	}
}
