using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008A0 RID: 2208
	public static class HeartDialScriptChangeScNotifyReflection
	{
		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x00107907 File Offset: 0x00105B07
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeartDialScriptChangeScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040025DD RID: 9693
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNIZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeS5wcm90bxoRS0dIRkpQ",
			"RUdCTkwucHJvdG8aGUhlYXJ0RGlhbFNjcmlwdEluZm8ucHJvdG8aG0hlYXJ0",
			"RGlhbERpYWxvZ3VlSW5mby5wcm90bxobSGVhcnREaWFsVW5sb2NrU3RhdHVz",
			"LnByb3RvIuUBCh1IZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeRIhCgtO",
			"REtKT1BMTERQSBgEIAMoCzIMLktHSEZKUEVHQk5MEi0KDXVubG9ja19zdGF0",
			"dXMYDyABKA4yFi5IZWFydERpYWxVbmxvY2tTdGF0dXMSNgoYY2hhbmdlZF9z",
			"Y3JpcHRfaW5mb19saXN0GAwgAygLMhQuSGVhcnREaWFsU2NyaXB0SW5mbxI6",
			"ChpjaGFuZ2VkX2RpYWxvZ3VlX2luZm9fbGlzdBgDIAMoCzIWLkhlYXJ0RGlh",
			"bERpYWxvZ3VlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			KGHFJPEGBNLReflection.Descriptor,
			HeartDialScriptInfoReflection.Descriptor,
			HeartDialDialogueInfoReflection.Descriptor,
			HeartDialUnlockStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeartDialScriptChangeScNotify), HeartDialScriptChangeScNotify.Parser, new string[]
			{
				"NDKJOPLLDPH",
				"UnlockStatus",
				"ChangedScriptInfoList",
				"ChangedDialogueInfoList"
			}, null, null, null, null)
		}));
	}
}
