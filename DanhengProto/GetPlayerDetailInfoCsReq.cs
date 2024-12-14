using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000769 RID: 1897
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerDetailInfoCsReq : IMessage<GetPlayerDetailInfoCsReq>, IMessage, IEquatable<GetPlayerDetailInfoCsReq>, IDeepCloneable<GetPlayerDetailInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x060054C5 RID: 21701 RVA: 0x000E3F50 File Offset: 0x000E2150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerDetailInfoCsReq> Parser
		{
			get
			{
				return GetPlayerDetailInfoCsReq._parser;
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x000E3F57 File Offset: 0x000E2157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerDetailInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x000E3F69 File Offset: 0x000E2169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerDetailInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x000E3F70 File Offset: 0x000E2170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerDetailInfoCsReq()
		{
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x000E3F78 File Offset: 0x000E2178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerDetailInfoCsReq(GetPlayerDetailInfoCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x000E3F9D File Offset: 0x000E219D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerDetailInfoCsReq Clone()
		{
			return new GetPlayerDetailInfoCsReq(this);
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x060054CB RID: 21707 RVA: 0x000E3FA5 File Offset: 0x000E21A5
		// (set) Token: 0x060054CC RID: 21708 RVA: 0x000E3FAD File Offset: 0x000E21AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x000E3FB6 File Offset: 0x000E21B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerDetailInfoCsReq);
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x000E3FC4 File Offset: 0x000E21C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerDetailInfoCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x000E3FF4 File Offset: 0x000E21F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x000E4033 File Offset: 0x000E2233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x000E403B File Offset: 0x000E223B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x000E4044 File Offset: 0x000E2244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x000E4078 File Offset: 0x000E2278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x000E40B6 File Offset: 0x000E22B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerDetailInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x000E40E7 File Offset: 0x000E22E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x000E40F0 File Offset: 0x000E22F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002149 RID: 8521
		private static readonly MessageParser<GetPlayerDetailInfoCsReq> _parser = new MessageParser<GetPlayerDetailInfoCsReq>(() => new GetPlayerDetailInfoCsReq());

		// Token: 0x0400214A RID: 8522
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400214B RID: 8523
		public const int UidFieldNumber = 8;

		// Token: 0x0400214C RID: 8524
		private uint uid_;
	}
}
