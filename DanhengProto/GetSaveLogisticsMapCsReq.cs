using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007DD RID: 2013
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSaveLogisticsMapCsReq : IMessage<GetSaveLogisticsMapCsReq>, IMessage, IEquatable<GetSaveLogisticsMapCsReq>, IDeepCloneable<GetSaveLogisticsMapCsReq>, IBufferMessage
	{
		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060059C8 RID: 22984 RVA: 0x000EF807 File Offset: 0x000EDA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSaveLogisticsMapCsReq> Parser
		{
			get
			{
				return GetSaveLogisticsMapCsReq._parser;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x000EF80E File Offset: 0x000EDA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSaveLogisticsMapCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x060059CA RID: 22986 RVA: 0x000EF820 File Offset: 0x000EDA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSaveLogisticsMapCsReq.Descriptor;
			}
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x000EF827 File Offset: 0x000EDA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveLogisticsMapCsReq()
		{
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x000EF82F File Offset: 0x000EDA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveLogisticsMapCsReq(GetSaveLogisticsMapCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x000EF848 File Offset: 0x000EDA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSaveLogisticsMapCsReq Clone()
		{
			return new GetSaveLogisticsMapCsReq(this);
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x000EF850 File Offset: 0x000EDA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSaveLogisticsMapCsReq);
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x000EF85E File Offset: 0x000EDA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSaveLogisticsMapCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x000EF87C File Offset: 0x000EDA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x000EF8A2 File Offset: 0x000EDAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x000EF8AA File Offset: 0x000EDAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x000EF8B3 File Offset: 0x000EDAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x000EF8CC File Offset: 0x000EDACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x000EF8F2 File Offset: 0x000EDAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSaveLogisticsMapCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x000EF90F File Offset: 0x000EDB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x000EF918 File Offset: 0x000EDB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022DE RID: 8926
		private static readonly MessageParser<GetSaveLogisticsMapCsReq> _parser = new MessageParser<GetSaveLogisticsMapCsReq>(() => new GetSaveLogisticsMapCsReq());

		// Token: 0x040022DF RID: 8927
		private UnknownFieldSet _unknownFields;
	}
}
