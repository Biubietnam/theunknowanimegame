using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001114 RID: 4372
	public static class SetMissionEventProgressCsReqReflection
	{
		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600C2FB RID: 49915 RVA: 0x0020B7FC File Offset: 0x002099FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetMissionEventProgressCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004ED1 RID: 20177
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTZXRNaXNzaW9uRXZlbnRQcm9ncmVzc0NzUmVxLnByb3RvIkoKHFNldE1p" + "c3Npb25FdmVudFByb2dyZXNzQ3NSZXESGAoQbWlzc2lvbl9ldmVudF9pZBgE" + "IAEoDRIQCghwcm9ncmVzcxgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetMissionEventProgressCsReq), SetMissionEventProgressCsReq.Parser, new string[]
			{
				"MissionEventId",
				"Progress"
			}, null, null, null, null)
		}));
	}
}
