using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013E4 RID: 5092
	public static class UpdateMovieRacingDataScRspReflection
	{
		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x0600E30F RID: 58127 RVA: 0x0025BFA5 File Offset: 0x0025A1A5
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateMovieRacingDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04005A4A RID: 23114
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVcGRhdGVNb3ZpZVJhY2luZ0RhdGFTY1JzcC5wcm90bxoQUmFjaW5nRGF0" + "YS5wcm90byJPChpVcGRhdGVNb3ZpZVJhY2luZ0RhdGFTY1JzcBIgCgtFSk9G" + "TE5HS0tJQRgFIAEoCzILLlJhY2luZ0RhdGESDwoHcmV0Y29kZRgNIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RacingDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMovieRacingDataScRsp), UpdateMovieRacingDataScRsp.Parser, new string[]
			{
				"EJOFLNGKKIA",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
