using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000011 RID: 17
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptedPamMissionExpireCsReq : IMessage<AcceptedPamMissionExpireCsReq>, IMessage, IEquatable<AcceptedPamMissionExpireCsReq>, IDeepCloneable<AcceptedPamMissionExpireCsReq>, IBufferMessage
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000032E8 File Offset: 0x000014E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptedPamMissionExpireCsReq> Parser
		{
			get
			{
				return AcceptedPamMissionExpireCsReq._parser;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000032EF File Offset: 0x000014EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptedPamMissionExpireCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003301 File Offset: 0x00001501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptedPamMissionExpireCsReq.Descriptor;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003308 File Offset: 0x00001508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptedPamMissionExpireCsReq()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003310 File Offset: 0x00001510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptedPamMissionExpireCsReq(AcceptedPamMissionExpireCsReq other) : this()
		{
			this.mainMissionId_ = other.mainMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003335 File Offset: 0x00001535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptedPamMissionExpireCsReq Clone()
		{
			return new AcceptedPamMissionExpireCsReq(this);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000333D File Offset: 0x0000153D
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00003345 File Offset: 0x00001545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000334E File Offset: 0x0000154E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptedPamMissionExpireCsReq);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000335C File Offset: 0x0000155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptedPamMissionExpireCsReq other)
		{
			return other != null && (other == this || (this.MainMissionId == other.MainMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000338C File Offset: 0x0000158C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000033CB File Offset: 0x000015CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000033D3 File Offset: 0x000015D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000033DC File Offset: 0x000015DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003410 File Offset: 0x00001610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000344E File Offset: 0x0000164E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptedPamMissionExpireCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000347F File Offset: 0x0000167F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003488 File Offset: 0x00001688
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
					this.MainMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000033 RID: 51
		private static readonly MessageParser<AcceptedPamMissionExpireCsReq> _parser = new MessageParser<AcceptedPamMissionExpireCsReq>(() => new AcceptedPamMissionExpireCsReq());

		// Token: 0x04000034 RID: 52
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000035 RID: 53
		public const int MainMissionIdFieldNumber = 7;

		// Token: 0x04000036 RID: 54
		private uint mainMissionId_;
	}
}
