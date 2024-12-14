using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008F4 RID: 2292
	public static class HKIPEMDOMMDReflection
	{
		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x0600664B RID: 26187 RVA: 0x00111741 File Offset: 0x0010F941
		public static FileDescriptor Descriptor
		{
			get
			{
				return HKIPEMDOMMDReflection.descriptor;
			}
		}

		// Token: 0x04002757 RID: 10071
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIS0lQRU1ET01NRC5wcm90byINCgtIS0lQRU1ET01NREIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HKIPEMDOMMD), HKIPEMDOMMD.Parser, null, null, null, null, null)
		}));
	}
}
