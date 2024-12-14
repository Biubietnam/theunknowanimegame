using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E0 RID: 4576
	public static class StatTypeReflection
	{
		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600CC99 RID: 52377 RVA: 0x002251A0 File Offset: 0x002233A0
		public static FileDescriptor Descriptor
		{
			get
			{
				return StatTypeReflection.descriptor;
			}
		}

		// Token: 0x0400527C RID: 21116
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5TdGF0VHlwZS5wcm90bypfCghTdGF0VHlwZRISCg5TVEFUX1RZUEVfTk9O" + "RRAAEhEKDVNUQVRfVFlQRV9BUlQQARIVChFTVEFUX1RZUEVfQ1VMVFVSRRAC" + "EhUKEVNUQVRfVFlQRV9QT1BVTEFSEANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
		{
			typeof(StatType)
		}, null, null));
	}
}
