using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011B4 RID: 4532
	public static class StartMatchCsReqReflection
	{
		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600CA6F RID: 51823 RVA: 0x0021F0E6 File Offset: 0x0021D2E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartMatchCsReqReflection.descriptor;
			}
		}

		// Token: 0x040051A6 RID: 20902
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVTdGFydE1hdGNoQ3NSZXEucHJvdG8aEVBHREFDTklCRk1QLnByb3RvGhNG",
			"aWdodEdhbWVNb2RlLnByb3RvIlkKD1N0YXJ0TWF0Y2hDc1JlcRIhCgtESUZO",
			"REVHTUtOQRgBIAEoCzIMLlBHREFDTklCRk1QEiMKC01HQUlBSkFLUEVJGAkg",
			"ASgOMg4uRmlnaHRHYW1lTW9kZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PGDACNIBFMPReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartMatchCsReq), StartMatchCsReq.Parser, new string[]
			{
				"DIFNDEGMKNA",
				"MGAIAJAKPEI"
			}, null, null, null, null)
		}));
	}
}
