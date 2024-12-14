using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BD8 RID: 3032
	public static class MusicRhythmDataCsReqReflection
	{
		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x06008633 RID: 34355 RVA: 0x00162298 File Offset: 0x00160498
		public static FileDescriptor Descriptor
		{
			get
			{
				return MusicRhythmDataCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003363 RID: 13155
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpNdXNpY1JoeXRobURhdGFDc1JlcS5wcm90byIrChRNdXNpY1JoeXRobURh" + "dGFDc1JlcRITCgtwbGF5ZXJfZGF0YRgGIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmDataCsReq), MusicRhythmDataCsReq.Parser, new string[]
			{
				"PlayerData"
			}, null, null, null, null)
		}));
	}
}
