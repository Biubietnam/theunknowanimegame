using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000415 RID: 1045
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnableRogueTalentCsReq : IMessage<EnableRogueTalentCsReq>, IMessage, IEquatable<EnableRogueTalentCsReq>, IDeepCloneable<EnableRogueTalentCsReq>, IBufferMessage
	{
		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x00080304 File Offset: 0x0007E504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnableRogueTalentCsReq> Parser
		{
			get
			{
				return EnableRogueTalentCsReq._parser;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x0008030B File Offset: 0x0007E50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnableRogueTalentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x0008031D File Offset: 0x0007E51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableRogueTalentCsReq.Descriptor;
			}
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00080324 File Offset: 0x0007E524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableRogueTalentCsReq()
		{
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x0008032C File Offset: 0x0007E52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableRogueTalentCsReq(EnableRogueTalentCsReq other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00080351 File Offset: 0x0007E551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableRogueTalentCsReq Clone()
		{
			return new EnableRogueTalentCsReq(this);
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x00080359 File Offset: 0x0007E559
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x00080361 File Offset: 0x0007E561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x0008036A File Offset: 0x0007E56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableRogueTalentCsReq);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00080378 File Offset: 0x0007E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableRogueTalentCsReq other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000803A8 File Offset: 0x0007E5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0U)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000803E7 File Offset: 0x0007E5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000803EF File Offset: 0x0007E5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000803F8 File Offset: 0x0007E5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x0008042C File Offset: 0x0007E62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0008046A File Offset: 0x0007E66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableRogueTalentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0U)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x0008049B File Offset: 0x0007E69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000804A4 File Offset: 0x0007E6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TalentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040012A3 RID: 4771
		private static readonly MessageParser<EnableRogueTalentCsReq> _parser = new MessageParser<EnableRogueTalentCsReq>(() => new EnableRogueTalentCsReq());

		// Token: 0x040012A4 RID: 4772
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012A5 RID: 4773
		public const int TalentIdFieldNumber = 5;

		// Token: 0x040012A6 RID: 4774
		private uint talentId_;
	}
}
