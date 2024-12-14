using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003B0 RID: 944
	public static class DisplayEquipmentInfoReflection
	{
		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x00074DCB File Offset: 0x00072FCB
		public static FileDescriptor Descriptor
		{
			get
			{
				return DisplayEquipmentInfoReflection.descriptor;
			}
		}

		// Token: 0x040010F8 RID: 4344
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEaXNwbGF5RXF1aXBtZW50SW5mby5wcm90byJgChREaXNwbGF5RXF1aXBt" + "ZW50SW5mbxILCgN0aWQYByABKA0SDAoEcmFuaxgMIAEoDRILCgNleHAYAiAB" + "KA0SEQoJcHJvbW90aW9uGAggASgNEg0KBWxldmVsGAogASgNQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DisplayEquipmentInfo), DisplayEquipmentInfo.Parser, new string[]
			{
				"Tid",
				"Rank",
				"Exp",
				"Promotion",
				"Level"
			}, null, null, null, null)
		}));
	}
}
