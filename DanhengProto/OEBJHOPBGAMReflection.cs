using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C46 RID: 3142
	public static class OEBJHOPBGAMReflection
	{
		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x06008B6F RID: 35695 RVA: 0x0017071F File Offset: 0x0016E91F
		public static FileDescriptor Descriptor
		{
			get
			{
				return OEBJHOPBGAMReflection.descriptor;
			}
		}

		// Token: 0x04003586 RID: 13702
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRUJKSE9QQkdBTS5wcm90byJXCgtPRUJKSE9QQkdBTRIRCglwcm9tb3Rp" + "b24YDCABKA0SDAoEcmFuaxgEIAEoDRILCgNleHAYBiABKA0SCwoDdGlkGA8g" + "ASgNEg0KBWxldmVsGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OEBJHOPBGAM), OEBJHOPBGAM.Parser, new string[]
			{
				"Promotion",
				"Rank",
				"Exp",
				"Tid",
				"Level"
			}, null, null, null, null)
		}));
	}
}
