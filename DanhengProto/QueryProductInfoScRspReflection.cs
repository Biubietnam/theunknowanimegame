using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D3A RID: 3386
	public static class QueryProductInfoScRspReflection
	{
		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x0600975D RID: 38749 RVA: 0x00193642 File Offset: 0x00191842
		public static FileDescriptor Descriptor
		{
			get
			{
				return QueryProductInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04003ADA RID: 15066
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtRdWVyeVByb2R1Y3RJbmZvU2NSc3AucHJvdG8aDVByb2R1Y3QucHJvdG8i",
			"hgEKFVF1ZXJ5UHJvZHVjdEluZm9TY1JzcBIdCgtEREdETFBGQkRBRRgJIAMo",
			"CzIILlByb2R1Y3QSDwoHcmV0Y29kZRgFIAEoDRITCgtFQkxITEtHTUlBTxgM",
			"IAEoDRITCgtHTkdPS0ZFTUNNSRgGIAEoBBITCgtLTktKUEVLSUtPTBgKIAEo",
			"DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ProductReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QueryProductInfoScRsp), QueryProductInfoScRsp.Parser, new string[]
			{
				"DDGDLPFBDAE",
				"Retcode",
				"EBLHLKGMIAO",
				"GNGOKFEMCMI",
				"KNKJPEKIKOL"
			}, null, null, null, null)
		}));
	}
}
