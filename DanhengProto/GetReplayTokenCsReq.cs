using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000799 RID: 1945
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetReplayTokenCsReq : IMessage<GetReplayTokenCsReq>, IMessage, IEquatable<GetReplayTokenCsReq>, IDeepCloneable<GetReplayTokenCsReq>, IBufferMessage
	{
		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x060056D4 RID: 22228 RVA: 0x000E8B8B File Offset: 0x000E6D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetReplayTokenCsReq> Parser
		{
			get
			{
				return GetReplayTokenCsReq._parser;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x060056D5 RID: 22229 RVA: 0x000E8B92 File Offset: 0x000E6D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetReplayTokenCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x060056D6 RID: 22230 RVA: 0x000E8BA4 File Offset: 0x000E6DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetReplayTokenCsReq.Descriptor;
			}
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x000E8BAB File Offset: 0x000E6DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetReplayTokenCsReq()
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x000E8BCC File Offset: 0x000E6DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetReplayTokenCsReq(GetReplayTokenCsReq other) : this()
		{
			this.eHOAOABENLA_ = other.eHOAOABENLA_;
			this.gOIBGNNMHAK_ = other.gOIBGNNMHAK_;
			this.lDEABGLLEEK_ = other.lDEABGLLEEK_;
			this.replayType_ = other.replayType_;
			this.stageId_ = other.stageId_;
			this.bNCOODAHHPC_ = other.bNCOODAHHPC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x000E8C38 File Offset: 0x000E6E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetReplayTokenCsReq Clone()
		{
			return new GetReplayTokenCsReq(this);
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x060056DA RID: 22234 RVA: 0x000E8C40 File Offset: 0x000E6E40
		// (set) Token: 0x060056DB RID: 22235 RVA: 0x000E8C48 File Offset: 0x000E6E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHOAOABENLA
		{
			get
			{
				return this.eHOAOABENLA_;
			}
			set
			{
				this.eHOAOABENLA_ = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x060056DC RID: 22236 RVA: 0x000E8C51 File Offset: 0x000E6E51
		// (set) Token: 0x060056DD RID: 22237 RVA: 0x000E8C59 File Offset: 0x000E6E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GOIBGNNMHAK
		{
			get
			{
				return this.gOIBGNNMHAK_;
			}
			set
			{
				this.gOIBGNNMHAK_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x060056DE RID: 22238 RVA: 0x000E8C6C File Offset: 0x000E6E6C
		// (set) Token: 0x060056DF RID: 22239 RVA: 0x000E8C74 File Offset: 0x000E6E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LDEABGLLEEK
		{
			get
			{
				return this.lDEABGLLEEK_;
			}
			set
			{
				this.lDEABGLLEEK_ = value;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x060056E0 RID: 22240 RVA: 0x000E8C7D File Offset: 0x000E6E7D
		// (set) Token: 0x060056E1 RID: 22241 RVA: 0x000E8C85 File Offset: 0x000E6E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplayType ReplayType
		{
			get
			{
				return this.replayType_;
			}
			set
			{
				this.replayType_ = value;
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x000E8C8E File Offset: 0x000E6E8E
		// (set) Token: 0x060056E3 RID: 22243 RVA: 0x000E8C96 File Offset: 0x000E6E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x060056E4 RID: 22244 RVA: 0x000E8C9F File Offset: 0x000E6E9F
		// (set) Token: 0x060056E5 RID: 22245 RVA: 0x000E8CA7 File Offset: 0x000E6EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BNCOODAHHPC
		{
			get
			{
				return this.bNCOODAHHPC_;
			}
			set
			{
				this.bNCOODAHHPC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x000E8CBA File Offset: 0x000E6EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetReplayTokenCsReq);
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x000E8CC8 File Offset: 0x000E6EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetReplayTokenCsReq other)
		{
			return other != null && (other == this || (this.EHOAOABENLA == other.EHOAOABENLA && !(this.GOIBGNNMHAK != other.GOIBGNNMHAK) && this.LDEABGLLEEK == other.LDEABGLLEEK && this.ReplayType == other.ReplayType && this.StageId == other.StageId && !(this.BNCOODAHHPC != other.BNCOODAHHPC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x000E8D5C File Offset: 0x000E6F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EHOAOABENLA != 0U)
			{
				num ^= this.EHOAOABENLA.GetHashCode();
			}
			if (this.GOIBGNNMHAK.Length != 0)
			{
				num ^= this.GOIBGNNMHAK.GetHashCode();
			}
			if (this.LDEABGLLEEK != 0U)
			{
				num ^= this.LDEABGLLEEK.GetHashCode();
			}
			if (this.ReplayType != ReplayType.None)
			{
				num ^= this.ReplayType.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.BNCOODAHHPC.Length != 0)
			{
				num ^= this.BNCOODAHHPC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x000E8E22 File Offset: 0x000E7022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x000E8E2A File Offset: 0x000E702A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x000E8E34 File Offset: 0x000E7034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BNCOODAHHPC.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.BNCOODAHHPC);
			}
			if (this.LDEABGLLEEK != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LDEABGLLEEK);
			}
			if (this.EHOAOABENLA != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EHOAOABENLA);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.StageId);
			}
			if (this.ReplayType != ReplayType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ReplayType);
			}
			if (this.GOIBGNNMHAK.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.GOIBGNNMHAK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x000E8F08 File Offset: 0x000E7108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EHOAOABENLA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHOAOABENLA);
			}
			if (this.GOIBGNNMHAK.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GOIBGNNMHAK);
			}
			if (this.LDEABGLLEEK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LDEABGLLEEK);
			}
			if (this.ReplayType != ReplayType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ReplayType);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.BNCOODAHHPC.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BNCOODAHHPC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x000E8FC8 File Offset: 0x000E71C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetReplayTokenCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EHOAOABENLA != 0U)
			{
				this.EHOAOABENLA = other.EHOAOABENLA;
			}
			if (other.GOIBGNNMHAK.Length != 0)
			{
				this.GOIBGNNMHAK = other.GOIBGNNMHAK;
			}
			if (other.LDEABGLLEEK != 0U)
			{
				this.LDEABGLLEEK = other.LDEABGLLEEK;
			}
			if (other.ReplayType != ReplayType.None)
			{
				this.ReplayType = other.ReplayType;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.BNCOODAHHPC.Length != 0)
			{
				this.BNCOODAHHPC = other.BNCOODAHHPC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x000E9072 File Offset: 0x000E7272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x000E907C File Offset: 0x000E727C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 18U)
					{
						this.BNCOODAHHPC = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.LDEABGLLEEK = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.EHOAOABENLA = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.StageId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ReplayType = (ReplayType)input.ReadEnum();
						continue;
					}
					if (num == 114U)
					{
						this.GOIBGNNMHAK = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021F6 RID: 8694
		private static readonly MessageParser<GetReplayTokenCsReq> _parser = new MessageParser<GetReplayTokenCsReq>(() => new GetReplayTokenCsReq());

		// Token: 0x040021F7 RID: 8695
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021F8 RID: 8696
		public const int EHOAOABENLAFieldNumber = 4;

		// Token: 0x040021F9 RID: 8697
		private uint eHOAOABENLA_;

		// Token: 0x040021FA RID: 8698
		public const int GOIBGNNMHAKFieldNumber = 14;

		// Token: 0x040021FB RID: 8699
		private string gOIBGNNMHAK_ = "";

		// Token: 0x040021FC RID: 8700
		public const int LDEABGLLEEKFieldNumber = 3;

		// Token: 0x040021FD RID: 8701
		private uint lDEABGLLEEK_;

		// Token: 0x040021FE RID: 8702
		public const int ReplayTypeFieldNumber = 13;

		// Token: 0x040021FF RID: 8703
		private ReplayType replayType_;

		// Token: 0x04002200 RID: 8704
		public const int StageIdFieldNumber = 7;

		// Token: 0x04002201 RID: 8705
		private uint stageId_;

		// Token: 0x04002202 RID: 8706
		public const int BNCOODAHHPCFieldNumber = 2;

		// Token: 0x04002203 RID: 8707
		private string bNCOODAHHPC_ = "";
	}
}
