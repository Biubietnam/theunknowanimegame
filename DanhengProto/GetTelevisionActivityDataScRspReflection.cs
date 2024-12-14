using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000822 RID: 2082
	public static class GetTelevisionActivityDataScRspReflection
	{
		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x000F661A File Offset: 0x000F481A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetTelevisionActivityDataScRspReflection.descriptor;
			}
		}

		// Token: 0x040023DC RID: 9180
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRHZXRUZWxldmlzaW9uQWN0aXZpdHlEYXRhU2NSc3AucHJvdG8aHFRlbGV2",
			"aXNpb25BY3Rpdml0eURhdGEucHJvdG8iXwoeR2V0VGVsZXZpc2lvbkFjdGl2",
			"aXR5RGF0YVNjUnNwEg8KB3JldGNvZGUYDCABKA0SLAoLTFBFQVBNUENGQkQY",
			"ASADKAsyFy5UZWxldmlzaW9uQWN0aXZpdHlEYXRhQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			TelevisionActivityDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetTelevisionActivityDataScRsp), GetTelevisionActivityDataScRsp.Parser, new string[]
			{
				"Retcode",
				"LPEAPMPCFBD"
			}, null, null, null, null)
		}));
	}
}
