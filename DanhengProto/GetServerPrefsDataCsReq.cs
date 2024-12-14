using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007ED RID: 2029
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetServerPrefsDataCsReq : IMessage<GetServerPrefsDataCsReq>, IMessage, IEquatable<GetServerPrefsDataCsReq>, IDeepCloneable<GetServerPrefsDataCsReq>, IBufferMessage
	{
		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06005A83 RID: 23171 RVA: 0x000F1584 File Offset: 0x000EF784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetServerPrefsDataCsReq> Parser
		{
			get
			{
				return GetServerPrefsDataCsReq._parser;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x000F158B File Offset: 0x000EF78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetServerPrefsDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06005A85 RID: 23173 RVA: 0x000F159D File Offset: 0x000EF79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetServerPrefsDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x000F15A4 File Offset: 0x000EF7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetServerPrefsDataCsReq()
		{
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x000F15AC File Offset: 0x000EF7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetServerPrefsDataCsReq(GetServerPrefsDataCsReq other) : this()
		{
			this.serverPrefsId_ = other.serverPrefsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x000F15D1 File Offset: 0x000EF7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetServerPrefsDataCsReq Clone()
		{
			return new GetServerPrefsDataCsReq(this);
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06005A89 RID: 23177 RVA: 0x000F15D9 File Offset: 0x000EF7D9
		// (set) Token: 0x06005A8A RID: 23178 RVA: 0x000F15E1 File Offset: 0x000EF7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ServerPrefsId
		{
			get
			{
				return this.serverPrefsId_;
			}
			set
			{
				this.serverPrefsId_ = value;
			}
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x000F15EA File Offset: 0x000EF7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetServerPrefsDataCsReq);
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x000F15F8 File Offset: 0x000EF7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetServerPrefsDataCsReq other)
		{
			return other != null && (other == this || (this.ServerPrefsId == other.ServerPrefsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x000F1628 File Offset: 0x000EF828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerPrefsId != 0U)
			{
				num ^= this.ServerPrefsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x000F1667 File Offset: 0x000EF867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x000F166F File Offset: 0x000EF86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x000F1678 File Offset: 0x000EF878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerPrefsId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ServerPrefsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x000F16AC File Offset: 0x000EF8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerPrefsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServerPrefsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x000F16EA File Offset: 0x000EF8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetServerPrefsDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerPrefsId != 0U)
			{
				this.ServerPrefsId = other.ServerPrefsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x000F171B File Offset: 0x000EF91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x000F1724 File Offset: 0x000EF924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ServerPrefsId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002323 RID: 8995
		private static readonly MessageParser<GetServerPrefsDataCsReq> _parser = new MessageParser<GetServerPrefsDataCsReq>(() => new GetServerPrefsDataCsReq());

		// Token: 0x04002324 RID: 8996
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002325 RID: 8997
		public const int ServerPrefsIdFieldNumber = 7;

		// Token: 0x04002326 RID: 8998
		private uint serverPrefsId_;
	}
}
