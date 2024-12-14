using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012F8 RID: 4856
	public static class TakeOffEquipmentCsReqReflection
	{
		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0600D8B4 RID: 55476 RVA: 0x00241C82 File Offset: 0x0023FE82
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeOffEquipmentCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005671 RID: 22129
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtUYWtlT2ZmRXF1aXBtZW50Q3NSZXEucHJvdG8iKgoVVGFrZU9mZkVxdWlw" + "bWVudENzUmVxEhEKCWF2YXRhcl9pZBgEIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffEquipmentCsReq), TakeOffEquipmentCsReq.Parser, new string[]
			{
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
