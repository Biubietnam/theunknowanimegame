using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001068 RID: 4200
	public static class SceneEntityMoveScRspReflection
	{
		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600BB12 RID: 47890 RVA: 0x001F72AF File Offset: 0x001F54AF
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityMoveScRspReflection.descriptor;
			}
		}

		// Token: 0x04004BE2 RID: 19426
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpTY2VuZUVudGl0eU1vdmVTY1JzcC5wcm90bxoSRW50aXR5TW90aW9uLnBy",
			"b3RvGhhDbGllbnREb3dubG9hZERhdGEucHJvdG8ifgoUU2NlbmVFbnRpdHlN",
			"b3ZlU2NSc3ASDwoHcmV0Y29kZRgIIAEoDRIpChJlbnRpdHlfbW90aW9uX2xp",
			"c3QYCyADKAsyDS5FbnRpdHlNb3Rpb24SKgoNZG93bmxvYWRfZGF0YRgMIAEo",
			"CzITLkNsaWVudERvd25sb2FkRGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EntityMotionReflection.Descriptor,
			ClientDownloadDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityMoveScRsp), SceneEntityMoveScRsp.Parser, new string[]
			{
				"Retcode",
				"EntityMotionList",
				"DownloadData"
			}, null, null, null, null)
		}));
	}
}
