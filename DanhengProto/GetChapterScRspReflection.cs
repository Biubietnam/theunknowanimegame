using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200064C RID: 1612
	public static class GetChapterScRspReflection
	{
		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x000C5FA6 File Offset: 0x000C41A6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChapterScRspReflection.descriptor;
			}
		}

		// Token: 0x04001CED RID: 7405
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHZXRDaGFwdGVyU2NSc3AucHJvdG8aEkNoYXB0ZXJCcmllZi5wcm90byJb" + "Cg9HZXRDaGFwdGVyU2NSc3ASIgoLTUJJSUNMRERORkYYDSADKAsyDS5DaGFw" + "dGVyQnJpZWYSDwoHcmV0Y29kZRgFIAEoDRITCgtGQUxESEdISUNHSRgGIAEo" + "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChapterBriefReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChapterScRsp), GetChapterScRsp.Parser, new string[]
			{
				"MBIICLDDNFF",
				"Retcode",
				"FALDHGHICGI"
			}, null, null, null, null)
		}));
	}
}
