using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003FA RID: 1018
	public static class EGBPFBMGIPFReflection
	{
		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0007D260 File Offset: 0x0007B460
		public static FileDescriptor Descriptor
		{
			get
			{
				return EGBPFBMGIPFReflection.descriptor;
			}
		}

		// Token: 0x04001237 RID: 4663
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFR0JQRkJNR0lQRi5wcm90byIeCgtFR0JQRkJNR0lQRhIPCgdhcmVhX2lk" + "GAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EGBPFBMGIPF), EGBPFBMGIPF.Parser, new string[]
			{
				"AreaId"
			}, null, null, null, null)
		}));
	}
}
