using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F08 RID: 3848
	public static class RogueMagicScepterInfoReflection
	{
		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x0600ABD7 RID: 43991 RVA: 0x001CEBA2 File Offset: 0x001CCDA2
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterInfoReflection.descriptor;
			}
		}

		// Token: 0x0400461A RID: 17946
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZU1hZ2ljU2NlcHRlckluZm8ucHJvdG8aF1JvZ3VlTWFnaWNTY2Vw" + "dGVyLnByb3RvIj8KFVJvZ3VlTWFnaWNTY2VwdGVySW5mbxImCgptYWdpY19p" + "dGVtGAwgASgLMhIuUm9ndWVNYWdpY1NjZXB0ZXJCHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RogueMagicScepterReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicScepterInfo), RogueMagicScepterInfo.Parser, new string[]
			{
				"MagicItem"
			}, null, null, null, null)
		}));
	}
}
