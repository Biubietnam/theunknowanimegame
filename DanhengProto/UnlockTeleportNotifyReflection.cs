using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013CA RID: 5066
	public static class UnlockTeleportNotifyReflection
	{
		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x0600E1DE RID: 57822 RVA: 0x00258EE0 File Offset: 0x002570E0
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockTeleportNotifyReflection.descriptor;
			}
		}

		// Token: 0x040059E1 RID: 23009
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVbmxvY2tUZWxlcG9ydE5vdGlmeS5wcm90byI9ChRVbmxvY2tUZWxlcG9y" + "dE5vdGlmeRITCgt0ZWxlcG9ydF9pZBgOIAEoDRIQCghlbnRyeV9pZBgMIAEo" + "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTeleportNotify), UnlockTeleportNotify.Parser, new string[]
			{
				"TeleportId",
				"EntryId"
			}, null, null, null, null)
		}));
	}
}
