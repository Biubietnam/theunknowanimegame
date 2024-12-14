using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000482 RID: 1154
	public static class EntityBindPropCsReqReflection
	{
		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x0600336F RID: 13167 RVA: 0x0008D57C File Offset: 0x0008B77C
		public static FileDescriptor Descriptor
		{
			get
			{
				return EntityBindPropCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001470 RID: 5232
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFbnRpdHlCaW5kUHJvcENzUmVxLnByb3RvGhBNb3Rpb25JbmZvLnByb3Rv" + "IkcKE0VudGl0eUJpbmRQcm9wQ3NSZXESEwoLQUdKTUFBS05KTU0YASABKAgS" + "GwoGbW90aW9uGAUgASgLMgsuTW90aW9uSW5mb0IeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EntityBindPropCsReq), EntityBindPropCsReq.Parser, new string[]
			{
				"AGJMAAKNJMM",
				"Motion"
			}, null, null, null, null)
		}));
	}
}
