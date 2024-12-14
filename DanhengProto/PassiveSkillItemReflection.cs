using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C7E RID: 3198
	public static class PassiveSkillItemReflection
	{
		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x00177934 File Offset: 0x00175B34
		public static FileDescriptor Descriptor
		{
			get
			{
				return PassiveSkillItemReflection.descriptor;
			}
		}

		// Token: 0x04003691 RID: 13969
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZQYXNzaXZlU2tpbGxJdGVtLnByb3RvIjEKEFBhc3NpdmVTa2lsbEl0ZW0S" + "DAoEc2xvdBgEIAEoDRIPCgdpdGVtX2lkGAogASgNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PassiveSkillItem), PassiveSkillItem.Parser, new string[]
			{
				"Slot",
				"ItemId"
			}, null, null, null, null)
		}));
	}
}
