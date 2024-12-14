using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D6 RID: 5078
	public static class UpdateFeatureSwitchScNotifyReflection
	{
		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x0600E262 RID: 57954 RVA: 0x0025A0E5 File Offset: 0x002582E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateFeatureSwitchScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005A05 RID: 23045
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFVcGRhdGVGZWF0dXJlU3dpdGNoU2NOb3RpZnkucHJvdG8aF0ZlYXR1cmVT" + "d2l0Y2hJbmZvLnByb3RvIkkKG1VwZGF0ZUZlYXR1cmVTd2l0Y2hTY05vdGlm" + "eRIqCg5Td2l0Y2hJbmZvTGlzdBgJIAMoCzISLkZlYXR1cmVTd2l0Y2hJbmZv" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			FeatureSwitchInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateFeatureSwitchScNotify), UpdateFeatureSwitchScNotify.Parser, new string[]
			{
				"SwitchInfoList"
			}, null, null, null, null)
		}));
	}
}
