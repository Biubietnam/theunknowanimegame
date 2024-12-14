using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E2 RID: 226
	public static class BattleEquipmentReflection
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0001DCC5 File Offset: 0x0001BEC5
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleEquipmentReflection.descriptor;
			}
		}

		// Token: 0x04000435 RID: 1077
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCYXR0bGVFcXVpcG1lbnQucHJvdG8iTQoPQmF0dGxlRXF1aXBtZW50EgoK" + "AmlkGAEgASgNEg0KBWxldmVsGAIgASgNEhEKCXByb21vdGlvbhgDIAEoDRIM" + "CgRyYW5rGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleEquipment), BattleEquipment.Parser, new string[]
			{
				"Id",
				"Level",
				"Promotion",
				"Rank"
			}, null, null, null, null)
		}));
	}
}
