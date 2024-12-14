using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200035A RID: 858
	public static class DAOPAFHNNAHReflection
	{
		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x0006B9AF File Offset: 0x00069BAF
		public static FileDescriptor Descriptor
		{
			get
			{
				return DAOPAFHNNAHReflection.descriptor;
			}
		}

		// Token: 0x04000F8A RID: 3978
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFEQU9QQUZITk5BSC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvImgKC0RB",
			"T1BBRkhOTkFIEhgKEGZyZWVfcmVmb3JnZV9udW0YCSABKA0SHQoVaW50X3Jl",
			"Zm9yZ2VfbnVtX3ZhbHVlGAUgASgFEiAKCWNvc3RfZGF0YRgNIAEoCzINLkl0",
			"ZW1Db3N0RGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DAOPAFHNNAH), DAOPAFHNNAH.Parser, new string[]
			{
				"FreeReforgeNum",
				"IntReforgeNumValue",
				"CostData"
			}, null, null, null, null)
		}));
	}
}
