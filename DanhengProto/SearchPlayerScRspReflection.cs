using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001092 RID: 4242
	public static class SearchPlayerScRspReflection
	{
		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600BD32 RID: 48434 RVA: 0x001FDEC3 File Offset: 0x001FC0C3
		public static FileDescriptor Descriptor
		{
			get
			{
				return SearchPlayerScRspReflection.descriptor;
			}
		}

		// Token: 0x04004CEE RID: 19694
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdTZWFyY2hQbGF5ZXJTY1JzcC5wcm90bxoWUGxheWVyU2ltcGxlSW5mby5w",
			"cm90byJqChFTZWFyY2hQbGF5ZXJTY1JzcBIPCgdyZXRjb2RlGAMgASgNEisK",
			"EHNpbXBsZV9pbmZvX2xpc3QYDCADKAsyES5QbGF5ZXJTaW1wbGVJbmZvEhcK",
			"D3Jlc3VsdF91aWRfbGlzdBgBIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SearchPlayerScRsp), SearchPlayerScRsp.Parser, new string[]
			{
				"Retcode",
				"SimpleInfoList",
				"ResultUidList"
			}, null, null, null, null)
		}));
	}
}
