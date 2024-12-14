using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D4D RID: 3405
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitLineupScRsp : IMessage<QuitLineupScRsp>, IMessage, IEquatable<QuitLineupScRsp>, IDeepCloneable<QuitLineupScRsp>, IBufferMessage
	{
		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x06009823 RID: 38947 RVA: 0x00195663 File Offset: 0x00193863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitLineupScRsp> Parser
		{
			get
			{
				return QuitLineupScRsp._parser;
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x06009824 RID: 38948 RVA: 0x0019566A File Offset: 0x0019386A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x06009825 RID: 38949 RVA: 0x0019567C File Offset: 0x0019387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitLineupScRsp.Descriptor;
			}
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x00195683 File Offset: 0x00193883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitLineupScRsp()
		{
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x0019568C File Offset: 0x0019388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitLineupScRsp(QuitLineupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.planeId_ = other.planeId_;
			this.nNPBEFLBLPG_ = other.nNPBEFLBLPG_;
			this.isVirtual_ = other.isVirtual_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x001956EC File Offset: 0x001938EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitLineupScRsp Clone()
		{
			return new QuitLineupScRsp(this);
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x06009829 RID: 38953 RVA: 0x001956F4 File Offset: 0x001938F4
		// (set) Token: 0x0600982A RID: 38954 RVA: 0x001956FC File Offset: 0x001938FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0600982B RID: 38955 RVA: 0x00195705 File Offset: 0x00193905
		// (set) Token: 0x0600982C RID: 38956 RVA: 0x0019570D File Offset: 0x0019390D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600982D RID: 38957 RVA: 0x00195716 File Offset: 0x00193916
		// (set) Token: 0x0600982E RID: 38958 RVA: 0x0019571E File Offset: 0x0019391E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NNPBEFLBLPG
		{
			get
			{
				return this.nNPBEFLBLPG_;
			}
			set
			{
				this.nNPBEFLBLPG_ = value;
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600982F RID: 38959 RVA: 0x00195727 File Offset: 0x00193927
		// (set) Token: 0x06009830 RID: 38960 RVA: 0x0019572F File Offset: 0x0019392F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVirtual
		{
			get
			{
				return this.isVirtual_;
			}
			set
			{
				this.isVirtual_ = value;
			}
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x06009831 RID: 38961 RVA: 0x00195738 File Offset: 0x00193938
		// (set) Token: 0x06009832 RID: 38962 RVA: 0x00195740 File Offset: 0x00193940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x00195749 File Offset: 0x00193949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitLineupScRsp);
		}

		// Token: 0x06009834 RID: 38964 RVA: 0x00195758 File Offset: 0x00193958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitLineupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.PlaneId == other.PlaneId && this.NNPBEFLBLPG == other.NNPBEFLBLPG && this.IsVirtual == other.IsVirtual && this.BaseAvatarId == other.BaseAvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x001957D4 File Offset: 0x001939D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this.NNPBEFLBLPG)
			{
				num ^= this.NNPBEFLBLPG.GetHashCode();
			}
			if (this.IsVirtual)
			{
				num ^= this.IsVirtual.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x00195877 File Offset: 0x00193A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x0019587F File Offset: 0x00193A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009838 RID: 38968 RVA: 0x00195888 File Offset: 0x00193A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NNPBEFLBLPG)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.NNPBEFLBLPG);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.IsVirtual)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsVirtual);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x00195938 File Offset: 0x00193B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this.NNPBEFLBLPG)
			{
				num += 2;
			}
			if (this.IsVirtual)
			{
				num += 2;
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x001959C0 File Offset: 0x00193BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitLineupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			if (other.NNPBEFLBLPG)
			{
				this.NNPBEFLBLPG = other.NNPBEFLBLPG;
			}
			if (other.IsVirtual)
			{
				this.IsVirtual = other.IsVirtual;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x00195A4C File Offset: 0x00193C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x00195A58 File Offset: 0x00193C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.NNPBEFLBLPG = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.PlaneId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.BaseAvatarId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsVirtual = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B28 RID: 15144
		private static readonly MessageParser<QuitLineupScRsp> _parser = new MessageParser<QuitLineupScRsp>(() => new QuitLineupScRsp());

		// Token: 0x04003B29 RID: 15145
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B2A RID: 15146
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04003B2B RID: 15147
		private uint retcode_;

		// Token: 0x04003B2C RID: 15148
		public const int PlaneIdFieldNumber = 8;

		// Token: 0x04003B2D RID: 15149
		private uint planeId_;

		// Token: 0x04003B2E RID: 15150
		public const int NNPBEFLBLPGFieldNumber = 2;

		// Token: 0x04003B2F RID: 15151
		private bool nNPBEFLBLPG_;

		// Token: 0x04003B30 RID: 15152
		public const int IsVirtualFieldNumber = 15;

		// Token: 0x04003B31 RID: 15153
		private bool isVirtual_;

		// Token: 0x04003B32 RID: 15154
		public const int BaseAvatarIdFieldNumber = 12;

		// Token: 0x04003B33 RID: 15155
		private uint baseAvatarId_;
	}
}
